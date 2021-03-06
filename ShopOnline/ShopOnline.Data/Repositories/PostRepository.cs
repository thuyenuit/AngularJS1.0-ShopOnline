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
    public interface IPostRepositorycs: IRepository<Post>
    {

    }

    public class PostRepositorycs : RepositoryBase<Post>, IPostRepositorycs
    {

        public PostRepositorycs(IDbFactory dbFactory) :
            base(dbFactory)
        {

        }


    }
}
