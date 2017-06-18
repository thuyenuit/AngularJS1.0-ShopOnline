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
        void Add(ProductCatgory productCategory);
        void Update(ProductCatgory productCategory);
        void Delele(int id);
        IEnumerable<ProductCatgory> GetAll();
        IEnumerable<ProductCatgory> GetAllPaging(int page, int pageSize, out int totalRow);
        ProductCatgory GetSingleById(int id);
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

        public void Add(ProductCatgory productCategory)
        {
            productCategoryRepository.Add(productCategory);
        }

        public void Delele(int id)
        {
            productCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCatgory> GetAll()
        {
            return productCategoryRepository.GetAll();
        }

        public IEnumerable<ProductCatgory> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return productCategoryRepository.GetMultiPaging(x => x.Status == true, out totalRow, page, pageSize);
        }

        public ProductCatgory GetSingleById(int id)
        {
            return productCategoryRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            unitOfWork.Commit();
        }

        public void Update(ProductCatgory productCategory)
        {
            productCategoryRepository.Update(productCategory);
        }
    }
}
