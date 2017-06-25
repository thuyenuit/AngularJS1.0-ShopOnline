using Microsoft.AspNet.Identity.EntityFramework;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data
{
    public class ShopOnlineDbcontext: IdentityDbContext<ApplicationUser>
    {
        public ShopOnlineDbcontext()
            : base("ShopOnlineConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footer { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuGroup> MenuGroup { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostCategory> PostCategory { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductTag> ProductTag { get; set; }
        public DbSet<Slide> Slide { get; set; }
        public DbSet<SystemConfig> SystemConfig { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<ErrorLog> ErrorLog { get; set; }

        public static ShopOnlineDbcontext Create()
        {
            return new ShopOnlineDbcontext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            modelBuilder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}
