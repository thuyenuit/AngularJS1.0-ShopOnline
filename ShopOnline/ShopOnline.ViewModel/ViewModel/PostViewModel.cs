using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.ViewModel.ViewModel
{
    public class PostViewModel
    {
        public int PostsID { get; set; }

        public string PostsName { get; set; }

        public string PostsAlias { get; set; }

        public int PostsCategoryID { get; set; }

        public string PostsImage { get; set; }

        public string PostsDescription { get; set; }

        public string PostsContent { get; set; }

        public bool? PostsHomeFlag { get; set; }

        public bool? PostsHotFlag { get; set; }

        public int? PostsViewCount { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string UpdateBy { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public bool Status { get; set; }

        public virtual PostCategoryViewModel PostCategory { get; set; }

        public virtual IEnumerable<PostTagViewModel> PostTags { set; get; }
    }
}
