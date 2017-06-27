using AutoMapper;
using ShopOnline.Model.Model;
using ShopOnline.Service.Services;
using ShopOnline.ViewModel.ViewModel;
using ShopOnline.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShopOnline.Web.Infrastructure.Extensions;

namespace ShopOnline.Web.API
{
    [RoutePrefix("productcategory")]
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

        [Route("getall")]
        public HttpResponseMessage GetAll(HttpRequestMessage request, int page, int pageSize)
        {
            return CreateHttpReponse(request, () =>
            {
                var lst = productCategoryService.GetAll();
                var lstResponse = Mapper.Map<List<ProductCategoryViewModel>>(lst);

                int totalRow = lstResponse.Count();
                var query = lstResponse.Skip((page) * pageSize).Take(pageSize);

                var paginationset = new PaginationSet<ProductCategoryViewModel>()
                {
                    Items = query.ToList(),
                    Page = page, 
                    TotalCount = totalRow,
                    TotalPages =  (int)Math.Ceiling((decimal)totalRow / pageSize)
                };
                var response = request.CreateResponse(HttpStatusCode.OK, paginationset);
                return response;
            });
        }

        [Route("create")]
        public HttpResponseMessage Create(HttpRequestMessage request, ProductCategoryViewModel productCategoryVM)
        {
            return CreateHttpReponse(request, () =>
            {
                HttpResponseMessage response = null;

                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadGateway, ModelState);
                }
                else
                {
                    ProductCategory objPG = new ProductCategory();
                    objPG.UpdateProductCategory(productCategoryVM);
                    objPG.CreateDate = DateTime.Now;

                    productCategoryService.Add(objPG);
                    productCategoryService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, objPG);
                }

                return response;
            });
        }

        [Route("update")]
        public HttpResponseMessage Update(HttpRequestMessage request, ProductCategoryViewModel productCategoryVM)
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
                    var productCategoryDB = productCategoryService.GetSingleById(productCategoryVM.ProductCategoryID);
                    productCategoryDB.UpdateProductCategory(productCategoryVM);
                    productCategoryService.Add(productCategoryDB);
                    productCategoryService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, productCategoryDB);
                }

                return response;
            });
        }


    }
}
