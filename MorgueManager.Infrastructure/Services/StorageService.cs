using Microsoft.EntityFrameworkCore;
using MorgueManager.Core.Common;
using MorgueManager.Core.DTOs;
using MorgueManager.Core.Enums;
using MorgueManager.Core.Interfaces.Services;
using MorgueManager.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MorgueManager.Core.Entities;

namespace MorgueManager.Infrastructure.Services
{
    public class StorageService : IStorageService
    {
        private readonly MorgueDbContext _context;

        public StorageService(MorgueDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<List<StorageSimpleDto>>> GetAvailableStoragesAsync()
        {
            try
            {
                var list = await _context.Storages
                    .Where(s => s.State == StorageState.Available) // Chỉ lấy ngăn trống
                    .OrderBy(s => s.LocationCode)
                    .Select(s => new StorageSimpleDto
                    {
                        Id = s.Id,
                        LocationCode = s.LocationCode
                    })
                    .ToListAsync();

                return ServiceResult<List<StorageSimpleDto>>.Ok(list);
            }
            catch (Exception ex)
            {
                return ServiceResult<List<StorageSimpleDto>>.Fail(ex.Message);
            }
        }
        public async Task<ServiceResult<List<StorageMapDto>>> GetStorageMapAsync()
        {
            try
            {
                // Lấy tất cả ngăn lạnh, Join với bảng Corpse để xem ai đang nằm
                // Logic: Lấy Corpse có Status = InStorage và StorageId khớp
                var list = await _context.Storages
                    .Include(s => s.Corpses)
                    .OrderBy(s => s.LocationCode)
                    .Select(s => new StorageMapDto
                    {
                        Id = s.Id,
                        LocationCode = s.LocationCode,
                        State = s.State,
                        Zone = s.Zone.ToString(),

                        // Lấy người đầu tiên đang ở trạng thái InStorage trong ngăn này (thực tế chỉ có 1)
                        OccupantName = s.Corpses.Where(c => c.Status == CorpseStatus.InStorage).Select(c => c.FullName).FirstOrDefault(),
                        Gender = s.Corpses.Where(c => c.Status == CorpseStatus.InStorage).Select(c => c.Gender == Gender.Male ? "Nam" : "Nữ").FirstOrDefault(),
                        ReceptionDate = s.Corpses.Where(c => c.Status == CorpseStatus.InStorage).Select(c => c.ReceptionTime.ToString("dd/MM HH:mm")).FirstOrDefault()
                    })
                    .ToListAsync();

                return ServiceResult<List<StorageMapDto>>.Ok(list);
            }
            catch (Exception ex)
            {
                return ServiceResult<List<StorageMapDto>>.Fail(ex.Message);
            }
        }
        public async Task<ServiceResult<bool>> ToggleMaintenanceAsync(int storageId, string reason)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var storage = await _context.Storages.FindAsync(storageId);
                if (storage == null) return ServiceResult<bool>.Fail("Không tìm thấy ngăn lạnh.");

                if (storage.State == StorageState.Occupied)
                    return ServiceResult<bool>.Fail("Không thể bảo trì ngăn đang chứa thi thể!");

                if (storage.State == StorageState.Available)
                {
                    // === CHUYỂN SANG BẢO TRÌ ===
                    storage.State = StorageState.Maintenance;

                    // Ghi log
                    var log = new MaintenanceLog
                    {
                        StorageId = storage.Id,
                        Reason = reason,
                        StartDate = DateTime.Now,
                        PerformedBy = "Admin", // Sau này lấy từ CurrentUser
                        CreatedDate = DateTime.Now
                    };
                    await _context.MaintenanceLogs.AddAsync(log);
                }
                else if (storage.State == StorageState.Maintenance)
                {
                    // === KẾT THÚC BẢO TRÌ ===
                    storage.State = StorageState.Available;

                    // Cập nhật log gần nhất
                    var lastLog = await _context.MaintenanceLogs
                        .Where(l => l.StorageId == storage.Id && l.EndDate == null)
                        .OrderByDescending(l => l.StartDate)
                        .FirstOrDefaultAsync();

                    if (lastLog != null)
                    {
                        lastLog.EndDate = DateTime.Now;
                        lastLog.Note += " | Đã hoàn tất sửa chữa.";
                    }
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return ServiceResult<bool>.Ok(true, "Cập nhật trạng thái thành công.");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return ServiceResult<bool>.Fail("Lỗi: " + ex.Message);
            }
        }
        public async Task<ServiceResult<bool>> ConfirmCleaningAsync(int storageId)
        {
            try
            {
                var storage = await _context.Storages.FindAsync(storageId);
                if (storage == null) return ServiceResult<bool>.Fail("Không tìm thấy ngăn lạnh.");

                if (storage.State != StorageState.PendingCleaning)
                    return ServiceResult<bool>.Fail("Ngăn này không ở trạng thái chờ vệ sinh.");

                // Chuyển về Sẵn sàng
                storage.State = StorageState.Available;
                storage.UpdatedDate = DateTime.Now;

                await _context.SaveChangesAsync();
                return ServiceResult<bool>.Ok(true, "Đã xác nhận vệ sinh. Ngăn lạnh sẵn sàng sử dụng.");
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Fail(ex.Message);
            }
        }
        public async Task<ServiceResult<bool>> MoveCorpseAsync(int currentStorageId, int targetStorageId)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var source = await _context.Storages.FindAsync(currentStorageId);
                var target = await _context.Storages.FindAsync(targetStorageId);

                if (source == null || target == null) return ServiceResult<bool>.Fail("Ngăn lạnh không tồn tại.");
                if (source.State != StorageState.Occupied) return ServiceResult<bool>.Fail("Ngăn nguồn không có thi thể.");
                if (target.State != StorageState.Available) return ServiceResult<bool>.Fail("Ngăn đích không trống.");

                // 1. Tìm thi thể đang ở ngăn nguồn
                var corpse = await _context.Corpses.FirstOrDefaultAsync(c => c.StorageId == source.Id && c.Status == CorpseStatus.InStorage);
                if (corpse == null) return ServiceResult<bool>.Fail("Không tìm thấy dữ liệu thi thể.");

                // 2. Chuyển đổi
                corpse.StorageId = target.Id; // Gán sang ngăn mới

                source.State = StorageState.PendingCleaning; // Ngăn cũ chuyển sang Chờ vệ sinh (Quy trình Y tế)
                target.State = StorageState.Occupied;        // Ngăn mới thành Có người

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return ServiceResult<bool>.Ok(true, "Chuyển ngăn thành công.");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return ServiceResult<bool>.Fail(ex.Message);
            }
        }
    }
}