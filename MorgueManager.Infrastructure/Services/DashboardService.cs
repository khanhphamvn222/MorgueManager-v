using Microsoft.EntityFrameworkCore;
using MorgueManager.Core.Common;
using MorgueManager.Core.DTOs;
using MorgueManager.Core.Enums;
using MorgueManager.Core.Interfaces.Services;
using MorgueManager.Infrastructure.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MorgueManager.Infrastructure.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly MorgueDbContext _context;

        public DashboardService(MorgueDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<DashboardKpiDto>> GetDashboardDataAsync()
        {
            var data = new DashboardKpiDto();

            try
            {
                // 1. Số liệu ngăn lạnh
                var storageStats = await _context.Storages
                    .GroupBy(s => s.State)
                    .Select(g => new { State = g.Key, Count = g.Count() })
                    .ToListAsync();

                data.AvailableSlots = storageStats.FirstOrDefault(x => x.State == StorageState.Available)?.Count ?? 0;
                data.OccupiedSlots = storageStats.FirstOrDefault(x => x.State == StorageState.Occupied)?.Count ?? 0;
                data.MaintenanceSlots = storageStats.FirstOrDefault(x => x.State == StorageState.Maintenance)?.Count ?? 0;

                // 2. Tổng số
                data.TotalCorpsesInMorgue = await _context.Corpses
                    .CountAsync(c => c.Status != CorpseStatus.HandedOver);

                // 3. Giá lưu trữ
                var priceConfig = await _context.SystemConfigs.FirstOrDefaultAsync(x => x.Key == "PricePerDay");
                if (priceConfig != null && decimal.TryParse(priceConfig.Value, out decimal price))
                {
                    data.CurrentStoragePrice = price;
                }
                else
                {
                    data.CurrentStoragePrice = 500000;
                }

                // 4. Biểu đồ
                var sevenDaysAgo = DateTime.Today.AddDays(-6);

                // Nhập
                var importData = await _context.Corpses
                    .Where(c => c.ReceptionTime >= sevenDaysAgo)
                    .GroupBy(c => c.ReceptionTime.Date)
                    .Select(g => new { Date = g.Key, Count = g.Count() })
                    .ToListAsync();

                // Xuất (Sử dụng !.Value để fix lỗi CS8629)
                var exportData = await _context.Corpses
                    .Where(c => c.HandoverTime != null && c.HandoverTime >= sevenDaysAgo)
                    .GroupBy(c => c.HandoverTime!.Value.Date)
                    .Select(g => new { Date = g.Key, Count = g.Count() })
                    .ToListAsync();

                for (int i = 0; i < 7; i++)
                {
                    var date = sevenDaysAgo.AddDays(i);
                    data.Labels.Add(date.ToString("dd/MM"));

                    var valImport = importData.FirstOrDefault(x => x.Date == date)?.Count ?? 0;
                    data.Values.Add(valImport);

                    var valExport = exportData.FirstOrDefault(x => x.Date == date)?.Count ?? 0;

                    // Kiểm tra null trước khi add để fix lỗi CS1061 nếu DTO chưa có list ExportValues
                    // Bạn cần đảm bảo đã thêm `public List<int> ExportValues { get; set; } = new List<int>();` vào DashboardKpiDto
                    if (data.ExportValues != null)
                    {
                        data.ExportValues.Add(valExport);
                    }
                }

                return ServiceResult<DashboardKpiDto>.Ok(data);
            }
            catch (Exception ex)
            {
                return ServiceResult<DashboardKpiDto>.Fail($"Lỗi Dashboard: {ex.Message}");
            }
        }
    }
}