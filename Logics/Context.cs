using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Logics.Data;

namespace Logics
{
   public class Context : DbContext
    {
        public Context() : base ("localsql")
        {
                
        }

        public DbSet<TvShows> TvShows { get; set; }

        public DbSet<Season> Seasons { get; set; }


    }
}
