﻿using ShopOnline.Model.Abstract;
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
        public int ProductCategoryID { get; set; }

        [Required]
        [MaxLength(255)]
        public string ProductCategoryName { get; set; }

        [Required]
        [MaxLength(255)]
        public string ProductCategoryAlias { get; set; }

        [MaxLength(255)]
        public string ProductCategoryDescription { get; set; }

        public int? ProductCategoryParentID { get; set; }

        public int? ProductCategoryDisplayOrder { get; set; }

        public string ProductCategoryImage { get; set; }

        public bool? ProductCategoryHomeFlag { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
