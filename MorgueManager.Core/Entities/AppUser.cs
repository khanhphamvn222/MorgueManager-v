using MorgueManager.Core.Common;
using MorgueManager.Core.Enums;

namespace MorgueManager.Core.Entities
{
    public class AppUser : BaseEntity
    {
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty; // Lưu chuỗi băm, KHÔNG lưu plain text
        public string FullName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public UserRole Role { get; set; } = UserRole.Staff;
        public bool IsActive { get; set; } = true;
    }
}