using ShopOnline.Data.Infrastructure.Interfaces;
using ShopOnline.Data.Repositories;
using ShopOnline.Model.Model;
using System.Collections.Generic;

namespace ShopOnline.Service.Services
{
    public interface IProductService
    {
        void Add(Product product);

        void Update(Product product);

        void Delele(int id);

        IEnumerable<Product> GetAll();

        IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow);

        Product GetSingleById(int id);

        void SaveChanges();
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProductService(
            IProductRepository productRepository,
            IUnitOfWork unitOfWork)
        {
            this.productRepository = productRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Add(Product product)
        {
            productRepository.Add(product);
        }

        public void Delele(int id)
        {
            productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return productRepository.GetAll();
        }

        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return productRepository.GetMultiPaging(x => x.Status == true, out totalRow, page, pageSize);
        }

        public Product GetSingleById(int id)
        {
            return productRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            productRepository.Update(product);
        }
    }
}