using Microsoft.EntityFrameworkCore;
using Project.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IDBColumns
    {
        private readonly ProjectDBContext _context;

        public GenericRepository(ProjectDBContext context) => _context = context;

        public async Task CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid ID)
        {
            var tEntity = await GetByIdAsync(ID);
            _context.Remove(tEntity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetByIdAsync(Guid ID)
        {
            return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.ID == ID);
        }

        public Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges() => _context.SaveChanges();

        public async Task UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }

        Task<IEnumerable<TEntity>> IGenericRepository<TEntity>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
