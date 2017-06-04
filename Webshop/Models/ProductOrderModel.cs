using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webshop.Models
{
    public class ProductOrderModel
    {
        [Required]
        [Display(Name = "ProductNameInput")]
        public string ProductNameInput { get; set; }
    }
}