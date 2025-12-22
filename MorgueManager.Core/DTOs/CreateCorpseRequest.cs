using MorgueManager.Core.Enums;
using System;

namespace MorgueManager.Core.DTOs
{
    public class CreateCorpseRequest
    {
        public string FullName { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string? IdentityNumber { get; set; } // CCCD
        public DateTime ReceptionTime { get; set; } = DateTime.Now;
        public int? StorageId { get; set; } // Ngăn lạnh được chọn
        public string? ImagePath { get; set; } // Đường dẫn ảnh
        public string? Notes { get; set; } // Ghi chú/Nguyên nhân
        public string? RelativeName { get; set; }
        public string? RelativePhone { get; set; }
        public string? RelativeAddress { get; set; }
        public string? PersonalBelongings { get; set; }
    }
}