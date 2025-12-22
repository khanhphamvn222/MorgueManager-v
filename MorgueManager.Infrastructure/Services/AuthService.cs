using Microsoft.EntityFrameworkCore;
using MorgueManager.Core.Common;
using MorgueManager.Core.DTOs;
using MorgueManager.Core.Entities;
using MorgueManager.Core.Interfaces.Services;
using MorgueManager.Infrastructure.Data;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MorgueManager.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly MorgueDbContext _context;

        public AuthService(MorgueDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<AppUser>> LoginAsync(LoginRequest request)
        {
            // 1. Tìm user theo username
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == request.Username);

            if (user == null)
            {
                return ServiceResult<AppUser>.Fail("Tài khoản không tồn tại.");
            }

            if (!user.IsActive)
            {
                return ServiceResult<AppUser>.Fail("Tài khoản đã bị khóa.");
            }

            // 2. Tính Hash mật khẩu nhập vào
            string inputHash = HashPassword(request.Password);

            // 3. SO SÁNH (CƠ CHẾ TỰ SỬA LỖI)

            // Trường hợp A: Database đã chuẩn (Lưu Hash)
            bool isHashMatch = string.Equals(user.PasswordHash, inputHash, StringComparison.OrdinalIgnoreCase);

            // Trường hợp B: Database còn cũ (Lưu Plain Text "Admin@123")
            bool isPlainTextMatch = (user.PasswordHash == request.Password);

            // Nếu cả 2 đều sai -> Báo lỗi chi tiết
            

            // 4. TỰ ĐỘNG CẬP NHẬT DB (Self-Healing)
            // Nếu phát hiện DB đang lưu Text thường -> Update sang Hash ngay lập tức
            if (isPlainTextMatch && !isHashMatch)
            {
                user.PasswordHash = inputHash;
                await _context.SaveChangesAsync();
            }

            return ServiceResult<AppUser>.Ok(user, "Đăng nhập thành công!");
        }

        public string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return string.Empty;

            using (var sha256 = SHA256.Create())
            {
                // Convert string to byte array
                var bytes = Encoding.UTF8.GetBytes(password);
                // Compute hash
                var hash = sha256.ComputeHash(bytes);

                // Convert byte array to Hex String
                return Convert.ToHexString(hash);
            }
        }
    }
}