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
        private static Fun_Killerapp_S2.Object.Customer current;
        private static decimal totalprice = 0;
        private static bool showcart = false;


        // GET: Customer
        public ActionResult CustomerMain()
        {

            if (Session["Allow"] == null)
            {
                Session["error"] = "Om deze pagina te betreden moet je aangemeld zijn";
                return RedirectToAction("Index", "Main");
            }

            //CurrentCustomer
            current = (Fun_Killerapp_S2.Object.Customer)Session["CurrentCustomer"];
            ViewData["CurrenCustomer"] = current;

            //CurrentProducts
            ViewBag.allproducts = cu.GetAllProducts();

            //productsincart
            ViewBag.cartproducts = shopcart;

            //showcart
            ViewBag.showcart = showcart;
            ViewBag.totalprice = totalprice;

            return View();
        }

        [HttpPost]
        public ActionResult CustomerMain(CustomerModel model)
        {
            //add product to cart
            if (model.ProductNameInput != null)
            {
                foreach (Product p in cu.GetAllProducts())
                {
                    if (model.ProductNameInput == p.Name)
                    {
                        Product added = p;
                        shopcart.Add(added);
                        totalprice = totalprice + p.Price;
                    }
                }
                showcart = false;
            }
            //Saveorder
            else if (model.ConfirmOrder != null)
            {
                cu.placeorder(shopcart, current.CustomerID);
                showcart = false;
                shopcart.Clear();
            }
            //Showcart
            else if (model.Showcart != null)
            {
                showcart = true;
            }
            //show filterlist
            else if (model.Searchinput != null)
            {
                List<Product> filterlist = new List<Product>();
                foreach (Product p in cu.GetAllProducts())
                {
                    if (p.Name.IndexOf(model.Searchinput, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        filterlist.Add(p);
                    }
                }
                ViewBag.filterlist = filterlist;
                showcart = false;
            }
            else if (model.Clearcart != null)
            {
                shopcart.Clear();
                totalprice = 0;
            }
            return View(CustomerMain());
        }
    }
}