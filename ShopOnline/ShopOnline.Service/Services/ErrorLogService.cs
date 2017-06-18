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
    public interface IErrorLogService
    {
        void Add(ErrorLog error);
     
        void SaveChanges();
    }
    class ErrorLogService : IErrorLogService
    {
        private readonly IErrorLogRepository errorLogRepository;
        private readonly IUnitOfWork unitOfWork;

        public ErrorLogService(
            IErrorLogRepository errorLogRepository,
            IUnitOfWork unitOfWork)
        {
            this.errorLogRepository = errorLogRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Add(ErrorLog error)
        {
            errorLogRepository.Add(error);
        }

        public void SaveChanges()
        {
            unitOfWork.Commit();
        }
    }
}
