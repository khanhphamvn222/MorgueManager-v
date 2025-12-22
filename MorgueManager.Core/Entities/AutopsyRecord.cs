using MorgueManager.Core.Common;
using System;

namespace MorgueManager.Core.Entities
{
    public class AutopsyRecord : BaseEntity
    {
        public int CorpseId { get; set; }
        public string DoctorName { get; set; } = string.Empty; // Bác sĩ pháp y
        public DateTime PerformedDate { get; set; } = DateTime.Now;
        public string ResultSummary { get; set; } = string.Empty; // Kết luận
        public string? DetailedReport { get; set; } // Mô tả chi tiết
        public string? AttachmentPath { get; set; } // File PDF biên bản pháp y

        // Navigation
        public virtual Corpse Corpse { get; set; } = null!;
    }
}