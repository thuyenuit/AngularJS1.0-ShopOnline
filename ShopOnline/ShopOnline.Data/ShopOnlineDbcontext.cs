using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data
{
    public class ShopOnlineDbcontext: DbContext
    {
        public ShopOnlineDbcontext()
            : base("ShopOnlineConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        //public DbSet<Footer> Footer { get; set; }
    }
}
