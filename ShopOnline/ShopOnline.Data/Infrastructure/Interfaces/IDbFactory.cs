using System;

namespace ShopOnline.Data.Infrastructure.Interfaces
{
    public interface IDbFactory : IDisposable
    {
        ShopOnlineDbcontext Init();
    }
}