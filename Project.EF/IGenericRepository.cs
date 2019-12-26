using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Schema;

namespace Project.EF
{
    public interface IGenericRepository<TEntity> where TEntity : class, IDBColumns
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetByIdAsync(Guid ID);

        Task CreateAsync(TEntity entity);

        Task UpdateAsync( TEntity entity);

        Task DeleteAsync(Guid ID);
    }
}
