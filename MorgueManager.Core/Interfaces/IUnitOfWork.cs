using MorgueManager.Core.Common;
using System;
using System.Threading.Tasks;

namespace MorgueManager.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // Sau này sẽ thêm các Repository cụ thể vào đây (VD: ICorpseRepository Corpses { get; })
        IGenericRepository<T> Repository<T>() where T : BaseEntity;

        Task<int> CompleteAsync(); // Hàm Commit Transaction (SaveChanges)
    }
}