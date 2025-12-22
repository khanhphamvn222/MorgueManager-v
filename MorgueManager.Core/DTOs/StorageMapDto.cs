using MorgueManager.Core.Enums;

namespace MorgueManager.Core.DTOs
{
    public class StorageMapDto
    {
        public int Id { get; set; }
        public string LocationCode { get; set; } = string.Empty; // A-01
        public StorageState State { get; set; }
        public string Zone { get; set; } = string.Empty; // Khu A/B

        // Thông tin người đang nằm (nếu có)
        public string? OccupantName { get; set; }
        public string? Gender { get; set; }
        public string? ReceptionDate { get; set; }
    }
}