using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Data.Infrastructure.Interfaces;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data.Repositories
{
    public interface IErrorLogRepository : IRepository<ErrorLog>
    {

    }

    public class ErrorLogRepository : RepositoryBase<ErrorLog>, IErrorLogRepository
    {

        public ErrorLogRepository(IDbFactory dbFactory) :
            base(dbFactory)
        {

        }


    }
}
