using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Data.Infrastructure.Interfaces;
using ShopOnline.Data.Repositories;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.UnitTest.RepositoryTest
{
    [TestClass]
    public class ProductCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IUnitOfWork unitOfWork;
        IProductCategoryRepository objRepository;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new ProductCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void ProductCategoryRepositoryCreate()
        {
            ProductCategory product = new ProductCategory();
            product.ProductCatgoryName = "San Pham 1";
            product.ProductCatgoryAlias = "San-Pham-1";
            product.Status = true;

            var result = objRepository.Add(product);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ProductCatgoryID);
        }
    }
}
