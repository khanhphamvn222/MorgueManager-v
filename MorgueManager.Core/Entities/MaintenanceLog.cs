using MorgueManager.Core.Common;
using System;

namespace MorgueManager.Core.Entities
{
    public class MaintenanceLog : BaseEntity
    {
        public int StorageId { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string? Note { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // Null = Chưa xong
        public string PerformedBy { get; set; } = "Admin";

        public virtual Storage Storage { get; set; } = null!;
    }
}