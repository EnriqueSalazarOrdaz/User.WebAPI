using Microsoft.EntityFrameworkCore;
using Project.Schema;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF
{
    public abstract class EFManager : GenericRepository<IDBColumns>
    {
        public EFManager(ProjectDBContext projectDBContext):base(projectDBContext) 
        {

        }
    }
}
