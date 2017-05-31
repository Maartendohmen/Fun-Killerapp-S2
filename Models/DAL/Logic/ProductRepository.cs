using Fun_Killerapp_S2.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Logic
{
    class ProductRepository
    {
        private IProduct context;

        public ProductRepository()
        {
            this.context = new ProductContext();
        }

        public List<Product> GetAllProducts(List<object> allsupliers, List<object> alldiscounts)
        {
            return this.context.GetAll(allsupliers, alldiscounts).Cast<Product>().ToList();
        }

        public Product GetOneProduct(int id, List<object> allsupliers, List<object> alldiscounts)
        {
            return (Product)this.context.GetOne(id,allsupliers,alldiscounts);
        }
    }
}
