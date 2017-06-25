using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.ViewModel.ViewModel
{
    public class TagViewModel
    {
        public int TagID { get; set; }

        public string TagName { get; set; }

        public string TagType { get; set; }

        public virtual IEnumerable<PostTagViewModel> PostTags { set; get; }

        public virtual IEnumerable<ProductTagViewModel> ProductTags { set; get; }
    }
}
