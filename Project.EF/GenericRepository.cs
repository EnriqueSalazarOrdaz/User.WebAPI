using Microsoft.EntityFrameworkCore;
using Project.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity>
    where TEntity : class, IDBColumns
    {
        private readonly ProjectDBContext _dbContext;
        public GenericRepository(ProjectDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid ID)
        {
            var entity = await GetByIdAsync(ID);
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetByIdAsync(Guid ID)
        {
            return await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.ID == ID);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
