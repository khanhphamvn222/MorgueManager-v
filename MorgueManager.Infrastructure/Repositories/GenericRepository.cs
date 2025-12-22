using Microsoft.EntityFrameworkCore;
using MorgueManager.Core.Common;
using MorgueManager.Core.Interfaces;
using MorgueManager.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MorgueManager.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly MorgueDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(MorgueDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            // Soft Delete logic
            entity.IsDeleted = true;
            entity.UpdatedDate = DateTime.Now;
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

            // Nếu muốn xóa cứng (Hard Delete) thì dùng: _dbSet.Remove(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                Delete(entity);
            }
        }
    }
}