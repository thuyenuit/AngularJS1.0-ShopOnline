using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Data.Infrastructure.Interfaces;
using ShopOnline.Data.Repositories;
using ShopOnline.Model.Model;

namespace ShopOnline.UnitTest.RepositoryUnitTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        IDbFactory dbFactory;
        IUnitOfWork unitOfWork;
        IProductRepository objRepository;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new ProductRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void ProductRepositoryCreate()
        {
            Product product = new Product();
            product.ProductName = "San Pham";
            product.ProductAlias = "San-Pham";
            product.ProductCategoryID = 1;
            product.ProductPrice = 100;
            product.Status = true;

            var result = objRepository.Add(product);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ProductID);
        }

        [TestMethod]
        public void ProductRepositoryUpdate()
        {
            var result = objRepository.GetSingleById(3);
            if (result != null)
            {
                result.ProductName = "Sản phẩm AB";
                result.ProductAlias = "San-pham-AB";

                objRepository.Update(result);
                unitOfWork.Commit();
            }

            Assert.IsNotNull(result);
            //Assert.AreEqual(1, result.ProductID);
        }


    }
}