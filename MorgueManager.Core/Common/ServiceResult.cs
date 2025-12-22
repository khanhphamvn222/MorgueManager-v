using System.Collections.Generic;

namespace MorgueManager.Core.Common
{
    public class ServiceResult<T>
    {
        public bool Success { get; set; }
        public T? Data { get; set; }
        public string Message { get; set; } = string.Empty;
        public List<string> Errors { get; set; } = new List<string>();

        public static ServiceResult<T> Ok(T data, string message = "Success")
        {
            return new ServiceResult<T> { Success = true, Data = data, Message = message };
        }

        public static ServiceResult<T> Fail(string message, List<string>? errors = null)
        {
            return new ServiceResult<T> { Success = false, Message = message, Errors = errors ?? new List<string>() };
        }
    }

    // Phiên bản không có data trả về (dùng cho void operations)
    public class ServiceResult
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;

        public static ServiceResult Ok(string message = "Success") => new ServiceResult { Success = true, Message = message };
        public static ServiceResult Fail(string message) => new ServiceResult { Success = false, Message = message };
    }
}