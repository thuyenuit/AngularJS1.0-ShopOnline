using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.ViewModel.ViewModel
{
    public class ProductCategoryViewModel
    {
        public int ProductCategoryID { get; set; }

        public string ProductCategoryName { get; set; }

        public string ProductCategoryAlias { get; set; }

        public string ProductCategoryDescription { get; set; }

        public int? ProductCategoryParentID { get; set; }

        public int? ProductCategoryDisplayOrder { get; set; }

        public string ProductCategoryImage { get; set; }

        public bool? ProductCategoryHomeFlag { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string UpdateBy { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public bool Status { get; set; }

        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}
