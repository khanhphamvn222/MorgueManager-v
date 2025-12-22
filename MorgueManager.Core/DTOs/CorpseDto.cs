using System;

namespace MorgueManager.Core.DTOs
{
    public class CorpseDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty; // Hiển thị "Nam"/"Nữ" thay vì Enum
        public string Status { get; set; } = string.Empty; // Hiển thị Status dạng chữ
        public string StorageLocation { get; set; } = "Chưa xếp"; // VD: A-01
        public DateTime ReceptionTime { get; set; }
        public string IdentityNumber { get; set; } = string.Empty; // CCCD
    }
}