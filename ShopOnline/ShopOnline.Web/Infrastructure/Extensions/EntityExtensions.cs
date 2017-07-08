using ShopOnline.Model.Model;
using ShopOnline.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVM)
        {
            postCategory.PostCategoryID = postCategoryVM.PostCategoryID;
            postCategory.PostCategoryName = postCategoryVM.PostCategoryName;
            postCategory.PostCategoryAlias = postCategoryVM.PostCategoryAlias;
            postCategory.PostCategoryDescription = postCategoryVM.PostCategoryDescription;
            postCategory.PostCategoryParentID = postCategoryVM.PostCategoryParentID;
            postCategory.PostCategoryDisplayOrder = postCategoryVM.PostCategoryDisplayOrder;
            postCategory.PostCategoryImage = postCategoryVM.PostCategoryImage;
            postCategory.PostCategoryHomeFlag = postCategoryVM.PostCategoryHomeFlag;
            postCategory.CreateDate = postCategoryVM.CreateDate;
            postCategory.CreateBy = postCategoryVM.CreateBy;
            postCategory.UpdateDate = postCategoryVM.UpdateDate;
            postCategory.UpdateBy = postCategoryVM.UpdateBy;
            postCategory.MetaKeyword = postCategoryVM.MetaKeyword;
            postCategory.MetaDescription = postCategoryVM.MetaDescription;
            postCategory.Status = postCategoryVM.Status;
        }

        public static void UpdateProductCategory(this ProductCategory proCategory, ProductCategoryViewModel proCategoryVM)
        {

            proCategory.ProductCategoryID = proCategoryVM.ProductCategoryID;
            proCategory.ProductCategoryName = proCategoryVM.ProductCategoryName;
            proCategory.ProductCategoryAlias = proCategoryVM.ProductCategoryAlias;
            proCategory.ProductCategoryDescription = proCategoryVM.ProductCategoryDescription;
            proCategory.ProductCategoryParentID = proCategoryVM.ProductCategoryParentID;
            proCategory.ProductCategoryDisplayOrder = proCategoryVM.ProductCategoryDisplayOrder;
            proCategory.ProductCategoryImage = proCategoryVM.ProductCategoryImage;
            proCategory.ProductCategoryHomeFlag = proCategoryVM.ProductCategoryHomeFlag;
            proCategory.CreateDate = proCategoryVM.CreateDate;
            proCategory.CreateBy = proCategoryVM.CreateBy;
            proCategory.UpdateDate = proCategoryVM.UpdateDate;
            proCategory.UpdateBy = proCategoryVM.UpdateBy;
            proCategory.MetaKeyword = proCategoryVM.MetaKeyword;
            proCategory.MetaDescription = proCategoryVM.MetaDescription;
            proCategory.Status = proCategoryVM.Status;
        }
    }
}