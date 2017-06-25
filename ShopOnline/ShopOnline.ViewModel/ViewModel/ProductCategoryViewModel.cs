using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.ViewModel.ViewModel
{
    public class ProductCategoryViewModel
    {
        public int ProductCatgoryID { get; set; }

        public string ProductCatgoryName { get; set; }

        public string ProductCatgoryAlias { get; set; }

        public string ProductCatgoryDescription { get; set; }

        public int? ProductCatgoryParentID { get; set; }

        public int? ProductCatgoryDisplayOrder { get; set; }

        public string ProductCatgoryImage { get; set; }

        public bool? ProductCatgoryHomeFlag { get; set; }

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
