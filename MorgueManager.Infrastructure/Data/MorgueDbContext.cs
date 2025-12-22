using Microsoft.EntityFrameworkCore;
using MorgueManager.Core.Entities;
using MorgueManager.Core.Enums;
using System.Reflection.Emit;

namespace MorgueManager.Infrastructure.Data
{
    public class MorgueDbContext : DbContext
    {
        public MorgueDbContext(DbContextOptions<MorgueDbContext> options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Corpse> Corpses { get; set; }
        public DbSet<PersonalBelonging> PersonalBelongings { get; set; }
        public DbSet<MaintenanceLog> MaintenanceLogs { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }

        // --- THÊM DBSET PHÁP Y ---
        public DbSet<AutopsyRecord> AutopsyRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình Global Query Filter cho Soft Delete (IsDeleted)
            modelBuilder.Entity<AppUser>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Storage>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Corpse>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<PersonalBelonging>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<MaintenanceLog>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<SystemConfig>().HasQueryFilter(x => !x.IsDeleted);

            // --- THÊM FILTER CHO AUTOPSY ĐỂ FIX WARNING ---
            modelBuilder.Entity<AutopsyRecord>().HasQueryFilter(x => !x.IsDeleted);

            // 2. Cấu hình Unique Index & Constraints
            modelBuilder.Entity<Storage>().HasIndex(s => s.LocationCode).IsUnique();
            modelBuilder.Entity<AppUser>().HasIndex(u => u.Username).IsUnique();
            modelBuilder.Entity<Corpse>().HasIndex(c => c.IdentityNumber).IsUnique();

            // 3. Data Seeding
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = 1,
                Username = "admin",
                PasswordHash = "240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9",
                FullName = "System Administrator",
                Role = UserRole.Admin,
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<SystemConfig>().HasData(
                new SystemConfig { Id = 1, Key = "PricePerDay", Value = "500000", Description = "Giá lưu kho mỗi ngày (VND)" },
                new SystemConfig { Id = 2, Key = "WarningThreshold", Value = "30", Description = "Cảnh báo lưu lâu quá (ngày)" }
            );

            var storages = new List<Storage>();
            int idCounter = 1;

            for (int i = 1; i <= 10; i++)
            {
                storages.Add(new Storage { Id = idCounter++, LocationCode = $"A-{i:00}", Zone = StorageZone.A, State = StorageState.Available, CreatedDate = DateTime.Now });
            }

            for (int i = 1; i <= 10; i++)
            {
                storages.Add(new Storage { Id = idCounter++, LocationCode = $"B-{i:00}", Zone = StorageZone.B, State = StorageState.Available, CreatedDate = DateTime.Now });
            }

            modelBuilder.Entity<Storage>().HasData(storages);
        }
    }
}