using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Schema;

namespace Project.EF
{
    public interface IGenericRepository<TEntity> where TEntity : class, IDBColumns
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetByIdAsync(Guid ID);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(Guid ID);


        void SaveChanges();
    }
}
