using MorgueManager.Core.Common;
using MorgueManager.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MorgueManager.Core.Interfaces.Services
{
    public interface ICorpseService
    {
        Task<ServiceResult<List<CorpseDto>>> GetAllCorpsesAsync(string? keyword = null);
        Task<ServiceResult<int>> CreateCorpseAsync(CreateCorpseRequest request);
        Task<ServiceResult<CorpseDetailDto>> GetCorpseDetailAsync(int id);
        Task<ServiceResult<bool>> HandoverCorpseAsync(int id);
        Task<ServiceResult<bool>> DeleteCorpseAsync(int id);
    }
}