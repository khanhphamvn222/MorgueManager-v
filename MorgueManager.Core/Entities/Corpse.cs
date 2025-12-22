using MorgueManager.Core.Common;
using MorgueManager.Core.Enums;
using System;
using System.Collections.Generic;

namespace MorgueManager.Core.Entities
{
    public class Corpse : BaseEntity
    {
        #region Info
        public string FullName { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public int? Age { get; set; }
        public CorpseStatus Status { get; set; } = CorpseStatus.Received;

        public int? StorageId { get; set; }
        public virtual Storage? Storage { get; set; }
        #endregion

        #region Identity
        public string IdentityCode { get; set; } = string.Empty;
        public string? IdentityNumber { get; set; }
        #endregion

        #region Details
        public string CauseOfDeath { get; set; } = string.Empty;
        public string? HealthTags { get; set; }
        public string? AttachmentPaths { get; set; }
        #endregion

        #region Dates
        public DateTime ReceptionTime { get; set; }
        public DateTime? DeathTime { get; set; }
        public DateTime? HandoverTime { get; set; } // Ngày bàn giao (cho biểu đồ Xuất)
        #endregion

        #region Relative & Belongings (MỚI)
        public string? RelativeName { get; set; }
        public string? RelativePhone { get; set; }
        public string? RelativeAddress { get; set; }

        // Trường này để lưu text nhập nhanh tư trang từ Form (Fix lỗi CS0029)
        public string? BelongingsInfo { get; set; }
        #endregion

        // Navigation (Giữ lại nếu muốn mở rộng chi tiết sau này)
        public virtual ICollection<PersonalBelonging> PersonalBelongings { get; set; } = new List<PersonalBelonging>();
        public virtual AutopsyRecord? AutopsyRecord { get; set; }
    }
}