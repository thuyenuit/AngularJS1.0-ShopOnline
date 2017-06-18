using ShopOnline.Model.Model;
using ShopOnline.Service.Services;
using ShopOnline.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopOnline.Web.API
{
    public class ProductCategoryController : BaseApiController
    {
        IProductCategoryService productCategoryService;
        public ProductCategoryController(
            IErrorLogService errorLogService,
            IProductCategoryService productCategoryService) 
            : base(errorLogService)
        {
            this.productCategoryService = productCategoryService;
        }

        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return CreateHttpReponse(request, () =>
            {
                var model = productCategoryService.GetAll();
                var response = request.CreateResponse(HttpStatusCode.OK, model);

                return response;
            });
        }

        public HttpResponseMessage Create(HttpRequestMessage request, ProductCategory productCategory)
        {
            return CreateHttpReponse(request, () =>
            {
                HttpResponseMessage response = null;

                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadGateway, ModelState);
                }
                else
                {
                    productCategoryService.Add(productCategory);
                    productCategoryService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, productCategory);
                }

                return response;
            });
        }


    }
}
