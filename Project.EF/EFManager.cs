using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF
{
    public abstract class EFManager
    {
        private readonly ProjectDBContext _projectContext;
        private static DbContextOptions<ProjectDBContext> _dbContextOptions;
        public EFManager(ProjectDBContext projectContext)
        {
            _projectContext = projectContext;
            //_dbContextOptions = dbContextOptions;
        }
        //protected static void Insert<T>(T entity)
        //{
        //    using (var context = new ProjectDBContext(_dbContextOptions))
        //    {
        //        context.Set<T>().Add(entity);
        //    };
        //}
        //public async Task Create(TEntity entity)
        //{
        //    await _projectContext.Set<TEntity>().AddAsync(entity);
        //    await _projectContext.SaveChangesAsync();
        //}
    }
}
