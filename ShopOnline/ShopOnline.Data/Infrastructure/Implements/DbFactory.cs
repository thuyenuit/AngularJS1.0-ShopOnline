using ShopOnline.Data.Infrastructure.Interfaces;

namespace ShopOnline.Data.Infrastructure.Implements
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopOnlineDbcontext dbContext;

        public ShopOnlineDbcontext Init()
        {
            return dbContext ?? (dbContext = new ShopOnlineDbcontext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}