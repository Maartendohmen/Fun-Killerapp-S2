using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webshop.Models
{
    public class CrewModel
    {

        [Display(Name = "OrderInput")]
        public int OrderInput { get; set; }

        [Display(Name = "ProductIDInput")]
        public int ProductIDInput { get; set; }

        [Display(Name = "Comment")]
        public  string Comment { get; set; }

        [Display(Name = "Amount")]
        public int Amount { get; set; }

        [Display (Name = "Time")]
        public DateTime Time { get; set; }

        [Display (Name = "Discountid")]
        public int Discountid { get; set; }

    }
}