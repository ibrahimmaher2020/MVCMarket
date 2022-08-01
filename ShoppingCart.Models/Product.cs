using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ShoppingCart.Models;

namespace ShoppingCart.DataAccess
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public Double Price { get; set; }
        [ValidateNever]
        public string ImgUrl{ get; set; }
        public int  CategoryID { get; set; }
        [ValidateNever]
        public Category Category { get; set; } 

    }
}
