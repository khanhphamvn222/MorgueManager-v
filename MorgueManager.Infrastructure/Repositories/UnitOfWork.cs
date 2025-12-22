using MorgueManager.Core.Common;
using MorgueManager.Core.Interfaces;
using MorgueManager.Infrastructure.Data;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace MorgueManager.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MorgueDbContext _context;
        private Hashtable? _repositories;

        public UnitOfWork(MorgueDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<T> Repository<T>() where T : BaseEntity
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
                _repositories.Add(type, repositoryInstance);
            }

            return (IGenericRepository<T>)_repositories[type]!;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}