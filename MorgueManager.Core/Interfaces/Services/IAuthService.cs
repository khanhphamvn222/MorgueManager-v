using MorgueManager.Core.Common;
using MorgueManager.Core.DTOs;
using MorgueManager.Core.Entities;
using System.Threading.Tasks;

namespace MorgueManager.Core.Interfaces.Services
{
    public interface IAuthService
    {
        Task<ServiceResult<AppUser>> LoginAsync(LoginRequest request);
        string HashPassword(string password); // Hàm hỗ trợ tạo hash
    }
}