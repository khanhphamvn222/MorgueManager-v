using MorgueManager.Core.Common;

namespace MorgueManager.Core.Entities
{
    public class SystemConfig : BaseEntity
    {
        public string Key { get; set; } = string.Empty; // VD: PricePerDay
        public string Value { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}