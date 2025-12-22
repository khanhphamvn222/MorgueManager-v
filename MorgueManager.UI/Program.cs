using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MorgueManager.Core.Interfaces;
using MorgueManager.Core.Interfaces.Services;
using MorgueManager.Infrastructure.Data;
using MorgueManager.Infrastructure.Repositories;
using MorgueManager.Infrastructure.Services;
// --- CÁC NAMESPACE VIEW ---
using MorgueManager.UI.Views.Auth;
using MorgueManager.UI.Views.Main;
using MorgueManager.UI.Views.Overview;
using MorgueManager.UI.Views.Corpse;
using MorgueManager.UI.Views.Storage;
using MorgueManager.UI.Views.Admin; // <--- QUAN TRỌNG: Thêm namespace Admin
// --------------------------
using System;
using System.IO;
using System.Windows.Forms;

namespace MorgueManager.UI
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; } = null!;
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Build Configuration
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            // 2. Setup DI Container
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // --- DATABASE ---
                    services.AddDbContext<MorgueDbContext>(options =>
                    {
                        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                    });

                    // --- REPOSITORIES & UNIT OF WORK ---
                    services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
                    services.AddScoped<IUnitOfWork, UnitOfWork>();

                    // --- BUSINESS SERVICES ---
                    services.AddScoped<IAuthService, AuthService>();
                    services.AddScoped<IDashboardService, DashboardService>();
                    services.AddScoped<ICorpseService, CorpseService>();
                    services.AddScoped<IStorageService, StorageService>();
                    services.AddScoped<IPdfService, PdfService>();
                    services.AddScoped<IAdminService, AdminService>();

                    // --- FORMS & DIALOGS ---
                    services.AddTransient<LoginSplitForm>();
                    services.AddTransient<DashboardForm>();
                    services.AddTransient<Views.Corpse.AddCorpseDialog>();
                    services.AddTransient<Views.Corpse.CorpseDetailsDialog>();

                    // --- USER CONTROLS (VIEWS) ---
                    services.AddTransient<UC_Dashboard>();
                    services.AddTransient<UC_CorpseList>();
                    services.AddTransient<UC_StorageMap>();
                    services.AddTransient<UC_Admin>(); // <--- ĐĂNG KÝ ADMIN VIEW
                })
                .Build();

            ServiceProvider = host.Services;

            // 3. Auto Migration
            using (var scope = ServiceProvider.CreateScope())
            {
                try
                {
                    var db = scope.ServiceProvider.GetRequiredService<MorgueDbContext>();
                    db.Database.Migrate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khởi tạo Database: {ex.Message}");
                }
            }

            // 4. Run App
            try
            {
                var loginForm = ServiceProvider.GetRequiredService<LoginSplitForm>();
                Application.Run(loginForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi chạy ứng dụng: {ex.Message}\n(Vui lòng kiểm tra lại DI Container hoặc Database)");
            }
        }
    }
}