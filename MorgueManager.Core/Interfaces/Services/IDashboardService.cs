using MorgueManager.Core.Common;
using MorgueManager.Core.DTOs;
using System.Threading.Tasks;

namespace MorgueManager.Core.Interfaces.Services
{
    public interface IDashboardService
    {
        Task<ServiceResult<DashboardKpiDto>> GetDashboardDataAsync();
    }
}