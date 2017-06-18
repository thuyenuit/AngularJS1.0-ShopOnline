using ShopOnline.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Model.Model
{
    [Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductCatgoryID { get; set; }

        [Required]
        [MaxLength(255)]
        public string ProductCatgoryName { get; set; }

        [Required]
        [MaxLength(255)]
        public string ProductCatgoryAlias { get; set; }

        [MaxLength(255)]
        public string ProductCatgoryDescription { get; set; }

        public int? ProductCatgoryParentID { get; set; }

        public int? ProductCatgoryDisplayOrder { get; set; }

        public string ProductCatgoryImage { get; set; }

        public bool? ProductCatgoryHomeFlag { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
