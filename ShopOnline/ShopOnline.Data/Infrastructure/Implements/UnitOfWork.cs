﻿using ShopOnline.Data.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data.Infrastructure.Implements
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private ShopOnlineDbcontext dbContext;

        public UnitOfWork(IDbFactory _dbFactory) {
            this.dbFactory = _dbFactory;
        }

        public ShopOnlineDbcontext DbContext
        {
            get { return dbContext ?? ( dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
