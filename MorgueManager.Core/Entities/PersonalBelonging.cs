using MorgueManager.Core.Common;

namespace MorgueManager.Core.Entities
{
    public class PersonalBelonging : BaseEntity
    {
        public int CorpseId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public bool IsReturned { get; set; } = false;

        public virtual Corpse Corpse { get; set; } = null!;
    }
}