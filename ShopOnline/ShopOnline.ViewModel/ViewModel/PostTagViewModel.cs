using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.ViewModel.ViewModel
{
    public class PostTagViewModel
    {
        public int PostID { get; set; }

        public int TagID { get; set; }

        public virtual PostViewModel Posts { get; set; }

        public virtual TagViewModel Tags { get; set; }
    }
}
