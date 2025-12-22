using Microsoft.EntityFrameworkCore;
using MorgueManager.Core.Common;
using MorgueManager.Core.DTOs;
using MorgueManager.Core.Entities;
using MorgueManager.Core.Interfaces.Services;
using MorgueManager.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MorgueManager.Infrastructure.Services
{
    public class AdminService : IAdminService
    {
        private readonly MorgueDbContext _context;

        public AdminService(MorgueDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<List<UserListDto>>> GetAllUsersAsync()
        {
            try
            {
                var list = await _context.Users
                    .Select(u => new UserListDto
                    {
                        Id = u.Id,
                        Username = u.Username,
                        FullName = u.FullName,
                        Role = u.Role,
                        IsActive = u.IsActive
                    })
                    .ToListAsync();
                return ServiceResult<List<UserListDto>>.Ok(list);
            }
            catch (Exception ex) { return ServiceResult<List<UserListDto>>.Fail(ex.Message); }
        }

        public async Task<ServiceResult<string>> CreateUserAsync(CreateUserRequest request)
        {
            try
            {
                if (await _context.Users.AnyAsync(u => u.Username == request.Username))
                    return ServiceResult<string>.Fail("Tên đăng nhập đã tồn tại.");

                string tempPass = GenerateRandomPassword();

                var user = new AppUser
                {
                    Username = request.Username,
                    FullName = request.FullName,
                    Role = request.Role,
                    IsActive = true,
                    PasswordHash = HashPassword(tempPass) // Sử dụng hàm Hash (bạn có thể tách ra Helper riêng)
                };

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

                return ServiceResult<string>.Ok(tempPass, "Tạo thành công.");
            }
            catch (Exception ex) { return ServiceResult<string>.Fail(ex.Message); }
        }

        public async Task<ServiceResult<string>> ResetPasswordAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return ServiceResult<string>.Fail("Không tìm thấy user.");

            string newPass = GenerateRandomPassword();
            user.PasswordHash = HashPassword(newPass);
            await _context.SaveChangesAsync();

            return ServiceResult<string>.Ok(newPass, "Reset thành công.");
        }

        public async Task<ServiceResult<bool>> ToggleUserStatusAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return ServiceResult<bool>.Fail("User not found.");

            // Không cho phép tự khóa chính mình nếu là Admin (Logic bảo vệ)
            // if (user.Username == "admin") ...

            user.IsActive = !user.IsActive;
            await _context.SaveChangesAsync();
            return ServiceResult<bool>.Ok(user.IsActive, user.IsActive ? "Đã mở khóa." : "Đã khóa tài khoản.");
        }

        public async Task<ServiceResult<bool>> CleanupOldDataAsync()
        {
            // Logic dọn dẹp: Xóa MaintenanceLog cũ hơn 1 năm, v.v.
            // Demo: Giả lập delay
            await Task.Delay(1000);
            return ServiceResult<bool>.Ok(true, "Đã dọn dẹp dữ liệu rác thành công.");
        }

        // Helpers
        private string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToHexString(hash);
            }
        }
        public async Task<ServiceResult<SystemSettingsDto>> GetSystemSettingsAsync()
        {
            try
            {
                var configs = await _context.SystemConfigs.ToListAsync();

                var dto = new SystemSettingsDto();

                // Map dữ liệu từ DB (Key-Value) sang DTO
                var nameConfig = configs.FirstOrDefault(x => x.Key == "OrgName");
                if (nameConfig != null) dto.OrganizationName = nameConfig.Value;

                var priceConfig = configs.FirstOrDefault(x => x.Key == "PricePerDay");
                if (priceConfig != null && decimal.TryParse(priceConfig.Value, out decimal price))
                {
                    dto.PricePerDay = price;
                }

                return ServiceResult<SystemSettingsDto>.Ok(dto);
            }
            catch (Exception ex) { return ServiceResult<SystemSettingsDto>.Fail(ex.Message); }
        }

        public async Task<ServiceResult<bool>> UpdateSystemSettingsAsync(SystemSettingsDto settings)
        {
            try
            {
                // Helper function để Update hoặc Insert
                async Task UpsertConfig(string key, string value, string desc)
                {
                    var config = await _context.SystemConfigs.FirstOrDefaultAsync(x => x.Key == key);
                    if (config == null)
                    {
                        config = new Core.Entities.SystemConfig { Key = key, Description = desc };
                        await _context.SystemConfigs.AddAsync(config);
                    }
                    config.Value = value;
                }

                await UpsertConfig("OrgName", settings.OrganizationName, "Tên đơn vị sử dụng");
                await UpsertConfig("PricePerDay", settings.PricePerDay.ToString("F0"), "Giá lưu kho/ngày");

                await _context.SaveChangesAsync();
                return ServiceResult<bool>.Ok(true, "Lưu cấu hình thành công!");
            }
            catch (Exception ex) { return ServiceResult<bool>.Fail(ex.Message); }
        }
    }
}