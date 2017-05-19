using Fun_Killerapp_S2.DAL.Interface;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Logic
{
    class SupplierRepository
    {
        private IMain context;

        public SupplierRepository()
        {
            this.context = new SupplierContext();
        }

        public List<Supplier> GetAllSuppliers()
        {
            return this.context.GetAll().Cast<Supplier>().ToList();
        }

        public Supplier GetOneSupplier(int id)
        {
            return (Supplier)this.context.GetOne(id);
        }
    }
}
