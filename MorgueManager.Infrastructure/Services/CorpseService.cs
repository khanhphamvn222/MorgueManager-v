using Microsoft.EntityFrameworkCore;
using MorgueManager.Core.Common;
using MorgueManager.Core.DTOs;
using MorgueManager.Core.Entities;
using MorgueManager.Core.Enums;
using MorgueManager.Core.Interfaces.Services;
using MorgueManager.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgueManager.Infrastructure.Services
{
    public class CorpseService : ICorpseService
    {
        private readonly MorgueDbContext _context;

        public CorpseService(MorgueDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<List<CorpseDto>>> GetAllCorpsesAsync(string? keyword = null)
        {
            try
            {
                var query = _context.Corpses
                    .Include(c => c.Storage)
                    .AsNoTracking()
                    .AsQueryable();

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    keyword = keyword.ToLower();
                    query = query.Where(c =>
                        c.FullName.ToLower().Contains(keyword) ||
                        (c.IdentityNumber != null && c.IdentityNumber.Contains(keyword)) ||
                        (c.Storage != null && c.Storage.LocationCode.ToLower().Contains(keyword)));
                }

                var list = await query
                    .OrderByDescending(c => c.ReceptionTime)
                    .Select(c => new CorpseDto
                    {
                        Id = c.Id,
                        FullName = c.FullName,
                        Gender = c.Gender == Gender.Male ? "Nam" : (c.Gender == Gender.Female ? "Nữ" : "Chưa rõ"),
                        IdentityNumber = c.IdentityNumber ?? "N/A",
                        ReceptionTime = c.ReceptionTime,
                        StorageLocation = c.Storage != null ? c.Storage.LocationCode : "Chưa xếp",
                        Status = c.Status == CorpseStatus.Received ? "Mới tiếp nhận" :
                                 (c.Status == CorpseStatus.InStorage ? "Đang lưu kho" : "Đã bàn giao")
                    })
                    .ToListAsync();

                return ServiceResult<List<CorpseDto>>.Ok(list);
            }
            catch (Exception ex)
            {
                return ServiceResult<List<CorpseDto>>.Fail($"Lỗi tải danh sách: {ex.Message}");
            }
        }

        public async Task<ServiceResult<int>> CreateCorpseAsync(CreateCorpseRequest request)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                if (!string.IsNullOrEmpty(request.IdentityNumber))
                {
                    bool exists = await _context.Corpses.AnyAsync(c => c.IdentityNumber == request.IdentityNumber);
                    if (exists) return ServiceResult<int>.Fail($"Số CCCD {request.IdentityNumber} đã tồn tại!");
                }

                var corpse = new Corpse
                {
                    FullName = request.FullName,
                    Gender = request.Gender,
                    IdentityNumber = request.IdentityNumber,
                    ReceptionTime = request.ReceptionTime,
                    CauseOfDeath = request.Notes ?? "Chưa xác định",
                    Status = CorpseStatus.Received,
                    AttachmentPaths = request.ImagePath,

                    // --- MAP THÔNG TIN MỚI (Đã có trong Entity) ---
                    RelativeName = request.RelativeName,
                    RelativePhone = request.RelativePhone,
                    RelativeAddress = request.RelativeAddress,
                    BelongingsInfo = request.PersonalBelongings, // Map string vào cột string (BelongingsInfo)
                    // ----------------------------------------------

                    CreatedDate = DateTime.Now
                };

                if (request.StorageId.HasValue)
                {
                    var storage = await _context.Storages.FindAsync(request.StorageId.Value);
                    if (storage == null) return ServiceResult<int>.Fail("Ngăn lạnh không tồn tại.");
                    if (storage.State != StorageState.Available) return ServiceResult<int>.Fail($"Ngăn {storage.LocationCode} đang không khả dụng!");

                    corpse.StorageId = storage.Id;
                    corpse.Status = CorpseStatus.InStorage;
                    storage.State = StorageState.Occupied;
                    storage.UpdatedDate = DateTime.Now;
                }

                await _context.Corpses.AddAsync(corpse);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return ServiceResult<int>.Ok(corpse.Id, "Tiếp nhận thành công!");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                string realError = ex.InnerException != null ? ex.InnerException.Message : ex.Message;

                return ServiceResult<int>.Fail($"Lỗi lưu Database: {realError}");
            }
        }

        public async Task<ServiceResult<CorpseDetailDto>> GetCorpseDetailAsync(int id)
        {
            try
            {
                var corpse = await _context.Corpses
                    .Include(c => c.Storage)
                    .FirstOrDefaultAsync(c => c.Id == id);

                if (corpse == null) return ServiceResult<CorpseDetailDto>.Fail("Không tìm thấy hồ sơ.");

                int days = (int)(DateTime.Now - corpse.ReceptionTime).TotalDays;
                if (days < 1) days = 1;

                decimal price = 500000;
                var configPrice = await _context.SystemConfigs.FirstOrDefaultAsync(x => x.Key == "PricePerDay");
                if (configPrice != null && decimal.TryParse(configPrice.Value, out decimal dbPrice))
                {
                    price = dbPrice;
                }

                return ServiceResult<CorpseDetailDto>.Ok(new CorpseDetailDto
                {
                    Id = corpse.Id,
                    FullName = corpse.FullName,
                    Gender = corpse.Gender == Gender.Male ? "Nam" : "Nữ",
                    IdentityNumber = corpse.IdentityNumber ?? "N/A",
                    ReceptionTime = corpse.ReceptionTime,
                    StorageLocation = corpse.Storage?.LocationCode ?? "Chưa xếp",
                    Status = corpse.Status == CorpseStatus.Received ? "Mới tiếp nhận" :
                             (corpse.Status == CorpseStatus.InStorage ? "Đang lưu kho" : "Đã bàn giao"),
                    Notes = corpse.CauseOfDeath,
                    ImagePath = corpse.AttachmentPaths ?? string.Empty,
                    DaysInStorage = days,
                    TotalCost = days * price
                });
            }
            catch (Exception ex)
            {
                return ServiceResult<CorpseDetailDto>.Fail(ex.Message);
            }
        }

        public async Task<ServiceResult<bool>> HandoverCorpseAsync(int id)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var corpse = await _context.Corpses.FindAsync(id);
                if (corpse == null) return ServiceResult<bool>.Fail("Hồ sơ không tồn tại.");

                corpse.Status = CorpseStatus.HandedOver;
                corpse.HandoverTime = DateTime.Now;

                // --- SỬA LOGIC TẠI ĐÂY ---
                if (corpse.StorageId.HasValue)
                {
                    var storage = await _context.Storages.FindAsync(corpse.StorageId.Value);
                    if (storage != null)
                    {
                        // Thay vì Available, ta chuyển sang PendingCleaning
                        storage.State = StorageState.PendingCleaning;
                        storage.UpdatedDate = DateTime.Now;
                    }
                }
                // -------------------------

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return ServiceResult<bool>.Ok(true, "Đã bàn giao. Ngăn lạnh chuyển sang trạng thái CHỜ VỆ SINH.");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return ServiceResult<bool>.Fail(ex.Message);
            }
        }

        public async Task<ServiceResult<bool>> DeleteCorpseAsync(int id)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var corpse = await _context.Corpses.FindAsync(id);
                if (corpse == null) return ServiceResult<bool>.Fail("Không tìm thấy.");

                corpse.IsDeleted = true; // Soft Delete

                if (corpse.StorageId.HasValue && corpse.Status == CorpseStatus.InStorage)
                {
                    var storage = await _context.Storages.FindAsync(corpse.StorageId.Value);
                    if (storage != null)
                    {
                        storage.State = StorageState.Available; // Giải phóng kho
                    }
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return ServiceResult<bool>.Ok(true, "Đã xóa hồ sơ.");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return ServiceResult<bool>.Fail(ex.Message);
            }
        }
    }
}