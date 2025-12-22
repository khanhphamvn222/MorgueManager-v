using System.ComponentModel;

namespace MorgueManager.Core.Enums
{
    // Trạng thái ngăn lạnh
    public enum StorageState
    {
        [Description("Trống")]
        Available = 0,

        [Description("Đang sử dụng")]
        Occupied = 1,

        [Description("Đang bảo trì")]
        Maintenance = 2,

        // --- THÊM MỚI ---
        [Description("Chờ vệ sinh/Khử khuẩn")]
        PendingCleaning = 3
    }

    // Khu vực (A/B)
    public enum StorageZone
    {
        A = 0,
        B = 1
    }

    // Trạng thái thi thể
    public enum CorpseStatus
    {
        [Description("Mới tiếp nhận")]
        Received = 0,

        [Description("Đang lưu kho")]
        InStorage = 1,

        [Description("Đã bàn giao")]
        HandedOver = 2
    }

    // Loại thông báo
    public enum NotificationType
    {
        Info = 0,
        Warning = 1,
        Error = 2,
        Success = 3
    }

    // Giới tính
    public enum Gender
    {
        Male = 0,
        Female = 1,
        Unknown = 2
    }
    public enum UserRole
    {
        Admin = 0,
        Staff = 1
    }

}