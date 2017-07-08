using AutoMapper;
using ShopOnline.Model.Model;
using ShopOnline.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<ProductTag, ProductTagViewModel>();
            });
        }
    }
}