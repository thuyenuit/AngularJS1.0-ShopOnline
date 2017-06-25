using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.ViewModel.ViewModel
{
    public class PostCategoryViewModel
    {
        public int PostCategoryID { get; set; }

        public string PostCategoryName { get; set; }

        public string PostCategoryAlias { get; set; }

        public string PostCategoryDescription { get; set; }

        public int? PostCategoryParentID { get; set; }

        public int? PostCategoryDisplayOrder { get; set; }

        public string PostCategoryImage { get; set; }

        public bool? PostCategoryHomeFlag { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string UpdateBy { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public bool Status { get; set; }

        public virtual IEnumerable<PostViewModel> Posts { get; set; }
    }
}
