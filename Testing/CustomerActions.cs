using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fun_Killerapp_S2;
using Fun_Killerapp_S2.Object;

namespace Testing
{
    [TestClass]
    public class CustomerActions
    {
        [TestMethod]
        public void TestGetAllProducts()
        {
            //laat zien dat alle producten worden ingeladen
            CustomerOverview cu = new CustomerOverview();
            Assert.IsNotNull(cu.GetAllProducts());
        }

        [TestMethod]
        public void TestAddProduct()
        {
            //laat zien dat je kan inloggen
            Product nieuw = new Product(15, new Supplier(20, "V&D", "Roermond"), 30, "Axe cool", Fun_Killerapp_S2.Object.Enum.ProductCatagorie.Productsoort.Spellen, 30);
        }
    }
}
