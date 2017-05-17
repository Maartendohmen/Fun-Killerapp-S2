using Fun_Killerapp_S2.Object;
using Fun_Killerapp_S2.Object.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
    public class Product
    {
        private int productid;
        private Supplier supplier;
        private List<Discount> discount;
        private decimal price;
        private string name;
        private ProductCatagorie.Productsoort categorie;
        private int amount;

        public int ProductID
        {
            get { return productid; }
            private set { productid = value; }
        }

        public Supplier Supplier
        {
            get { return supplier; }
            private set { supplier = value; }
        }

        public List<Discount> Discount
        {
            get { return discount; }
            private set { discount = value; }
        }

        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public ProductCatagorie.Productsoort Categorie
        {
            get { return categorie; }
            private set { categorie = value; }
        }

        public int Amount
        {
            get { return amount; }
            private set { amount = value; }
        }

        public Product(int productid, Supplier supplier, List<Discount> discount,decimal price,string name, ProductCatagorie.Productsoort categorie, int amount)
        {
            this.productid = productid;
            this.supplier = supplier;
            this.discount = discount;
            this.price = price;
            this.name = name;
            this.categorie = categorie;
            this.amount = amount;
        }


    }
}
