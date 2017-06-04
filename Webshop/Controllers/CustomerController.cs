using Fun_Killerapp_S2;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class CustomerController : Controller
    {
        private static List<Product> shopcart = new List<Product>();
        private static CustomerOverview cu = new CustomerOverview();
        private static Customer current;


        // GET: Customer
        public ActionResult CustomerMain()
        {
            //CurrentCustomer
            current = (Customer)Session["CurrentCustomer"];
            ViewData["CurrenCustomer"] = current;

            //CurrentProducts
            List<Product> getallproducts = cu.GetAllProducts();
            ViewBag.allproducts = getallproducts;

            //productsincart
            List<Product> cartproducts = shopcart;
            ViewBag.cartproducts = cartproducts;
            return View();
        }

        [HttpPost]
        public ActionResult CustomerMain(ProductOrderModel model)
        {
            foreach (Product p in cu.GetAllProducts())
            {
                if (model.ProductNameInput == p.Name)
                {
                    Product added = p;
                    shopcart.Add(added);
                }
            }
            return View(CustomerMain());
           // lbnumberofproducts.Text = "Number of products in cart : " + shopcart.Count();
        }
    }
}