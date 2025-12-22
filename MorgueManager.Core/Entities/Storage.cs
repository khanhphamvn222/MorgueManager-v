using MorgueManager.Core.Common;
using MorgueManager.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace MorgueManager.Core.Entities
{
    public class Storage : BaseEntity
    {
        public string LocationCode { get; set; } = string.Empty; // VD: A-01, B-05
        public StorageZone Zone { get; set; }
        public StorageState State { get; set; } = StorageState.Available;

        // Optimistic Concurrency
        [Timestamp]
        public byte[] RowVersion { get; set; } = [];

        // Navigation
        public virtual ICollection<MaintenanceLog> MaintenanceLogs { get; set; } = new List<MaintenanceLog>();
        public virtual ICollection<Corpse> Corpses { get; set; } = new List<Corpse>();
    }
}