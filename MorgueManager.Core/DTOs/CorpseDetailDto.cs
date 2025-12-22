using System;

namespace MorgueManager.Core.DTOs
{
    public class CorpseDetailDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string IdentityNumber { get; set; } = string.Empty;
        public DateTime ReceptionTime { get; set; }

        // Thông tin lưu trữ
        public string StorageLocation { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;

        // Thông tin thanh toán (Tính toán)
        public int DaysInStorage { get; set; }
        public decimal TotalCost { get; set; }
    }
}