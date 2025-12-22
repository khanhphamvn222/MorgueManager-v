using MorgueManager.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MorgueManager.Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        Task AddAsync(T entity);
        void Update(T entity); // EF Core chỉ đánh dấu state, không cần async
        void Delete(T entity); // Soft delete
        Task DeleteAsync(int id); // Tìm và Soft delete theo ID
    }
}