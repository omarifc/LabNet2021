using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.OmarSanchezUrra.EF.Data;
using Lab.OmarSanchezUrra.EF.Entities;

namespace Lab.OmarSanchezUrra.EF.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }
        public void Add(Shippers newShipper)
        {
            context.Shippers.Add(newShipper);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var shipperAEliminar = context.Shippers.Find(id);

            context.Shippers.Remove(shipperAEliminar);

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
        public void Update(Shippers shipper)
        {
            var shipperUpdate = context.Shippers.Find(shipper.ShipperID);
            shipperUpdate.CompanyName = shipper.CompanyName;
            shipperUpdate.Phone = shipper.Phone;
            context.SaveChanges();
        }
    }
}
