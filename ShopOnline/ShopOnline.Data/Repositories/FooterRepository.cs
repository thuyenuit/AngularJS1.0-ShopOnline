﻿using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Data.Infrastructure.Interfaces;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {
       
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {

        public FooterRepository(DbFactory dbFactory) :
            base(dbFactory)
        {

        }

       
    }
}
