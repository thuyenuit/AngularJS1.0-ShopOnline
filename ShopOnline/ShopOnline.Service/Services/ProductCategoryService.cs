using ShopOnline.Data.Infrastructure.Interfaces;
using ShopOnline.Data.Repositories;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Service.Services
{
    public interface IProductCategoryService
    {
        void Add(ProductCategory productCategory);
        void Update(ProductCategory productCategory);
        void Delele(int id);
        IEnumerable<ProductCategory> GetAll();
        IEnumerable<ProductCategory> GetAllPaging(int page, int pageSize, out int totalRow);
        ProductCategory GetSingleById(int id);
        void SaveChanges();
    }

    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository productCategoryRepository;
        private readonly IUnitOfWork unitOfWork;
        public ProductCategoryService(
            IProductCategoryRepository productCategoryRepository,
            IUnitOfWork unitOfWork)
        {
            this.productCategoryRepository = productCategoryRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Add(ProductCategory productCategory)
        {
            productCategoryRepository.Add(productCategory);
        }

        public void Delele(int id)
        {
            productCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return productCategoryRepository.GetAll();
        }

        public IEnumerable<ProductCategory> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return productCategoryRepository.GetMultiPaging(x => x.Status == true, out totalRow, page, pageSize);
        }

        public ProductCategory GetSingleById(int id)
        {
            return productCategoryRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            unitOfWork.Commit();
        }

        public void Update(ProductCategory productCategory)
        {
            productCategoryRepository.Update(productCategory);
        }
    }
}
