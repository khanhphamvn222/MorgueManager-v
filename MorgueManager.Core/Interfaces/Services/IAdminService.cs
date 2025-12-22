using MorgueManager.Core.Common;
using MorgueManager.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MorgueManager.Core.Interfaces.Services
{
    public interface IAdminService
    {
        Task<ServiceResult<List<UserListDto>>> GetAllUsersAsync();
        Task<ServiceResult<string>> CreateUserAsync(CreateUserRequest request); // Trả về mật khẩu tạm
        Task<ServiceResult<string>> ResetPasswordAsync(int userId); // Trả về mật khẩu mới
        Task<ServiceResult<bool>> ToggleUserStatusAsync(int userId); // Khóa/Mở khóa
        Task<ServiceResult<bool>> CleanupOldDataAsync(); // Dọn dẹp dữ liệu cũ
        Task<ServiceResult<SystemSettingsDto>> GetSystemSettingsAsync();
        Task<ServiceResult<bool>> UpdateSystemSettingsAsync(SystemSettingsDto settings);
    }
}
