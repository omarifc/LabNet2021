using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using Lab.OmarSanchezUrra.EF.Data;
using Lab.OmarSanchezUrra.EF.Entities;

namespace Lab.OmarSanchezUrra.EF.Logic
{
    public class SuppliersLogic : BaseLogic, IABMLogic<Suppliers>
    {   
        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }

        public void Add(Suppliers newSupplier) {

            context.Suppliers.Add(newSupplier);
            context.SaveChanges();
        }

        public void Delete(int id) {

            var supplierAEliminar = context.Suppliers.Find(id);

            context.Suppliers.Remove(supplierAEliminar);

            try
            {
                context.SaveChanges();
                Console.WriteLine($"El elemento {id} ha sido eliminado");
                Console.WriteLine("");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(string.Format("No se pudo eliminar el registro {0} porque está relacionado a otra tabla", id));
            }
        }
        public void Update(Suppliers supplier)
        {
            var supplierUpdate = context.Suppliers.Find(supplier.SupplierID);
            supplierUpdate.CompanyName = supplier.CompanyName;
            supplierUpdate.ContactName = supplier.ContactName;
            context.SaveChanges();
        }
    }
}
