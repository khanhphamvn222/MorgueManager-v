using MorgueManager.Core.Common;
using MorgueManager.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MorgueManager.Core.Interfaces.Services
{
    public interface IStorageService
    {
        Task<ServiceResult<List<StorageSimpleDto>>> GetAvailableStoragesAsync();
        Task<ServiceResult<List<StorageMapDto>>> GetStorageMapAsync();
        Task<ServiceResult<bool>> ToggleMaintenanceAsync(int storageId, string reason);
        Task<ServiceResult<bool>> ConfirmCleaningAsync(int storageId);
    }
}