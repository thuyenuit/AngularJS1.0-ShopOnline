using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.ViewModel.ViewModel
{
    public class ProductTagViewModel
    {
        public int ProductID { set; get; }

        public int TagID { set; get; }

        public virtual ProductViewModel Products { set; get; }

        public virtual TagViewModel Tags { set; get; }
    }
}
