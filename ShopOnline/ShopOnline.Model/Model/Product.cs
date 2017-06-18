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
    [Table("Products")]
    public class Product: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Required]
        [MaxLength(255)]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(255)]
        public string ProductAlias { get; set; }

        public int ProductCategoryID { get; set; }

        [ForeignKey("ProductCategoryID")]
        public virtual ProductCatgory ProductCategory { get; set; }

        [MaxLength(500)]
        public string ProductImage { get; set; }

        [Column(TypeName="xml")]
        public string ProductMoreImage { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal? ProductPromotionPrice { get; set; }

        public int? ProductWarranty { get; set; }

        public string ProductDescription { get; set; }

        public string ProductContent { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }
    }
}
