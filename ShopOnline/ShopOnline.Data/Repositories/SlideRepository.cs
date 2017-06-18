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
    public interface ISlideRepository : IRepository<Slide>
    {

    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {

        public SlideRepository(DbFactory dbFactory) :
            base(dbFactory)
        {

        }


    }
}
