using System.Collections.Generic;

namespace MorgueManager.Core.DTOs
{
    public class DashboardKpiDto
    {
        // KPI Cards
        public int TotalCorpsesInMorgue { get; set; } // Đang lưu giữ (Chưa bàn giao)
        public int AvailableSlots { get; set; }       // Ngăn trống
        public int OccupiedSlots { get; set; }        // Ngăn đang có người
        public int MaintenanceSlots { get; set; }
        public decimal CurrentStoragePrice { get; set; } 

        // Chart Data (Dữ liệu 7 ngày qua)
        public List<string> Labels { get; set; } = new List<string>(); // Ngày (20/10, 21/10...)
        public List<int> Values { get; set; } = new List<int>();       // Số lượng tiếp nhận
        public List<int> ExportValues { get; set; } = new List<int>();
    }
}