using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.OmarSanchezUrra.EF.Logic;
using Lab.OmarSanchezUrra.EF.Entities;

namespace Lab.OmarSanchezUrra.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            SuppliersLogic suppliersLogic = new SuppliersLogic();

            #region GetAll
            Console.WriteLine("----------------MUESTRA CARGADORES-------------------------------");

            foreach (Shippers shipper in shippersLogic.GetAll())
            {
                Console.WriteLine($"Nombre de la compañía: {shipper.CompanyName} || Teléfono: {shipper.Phone}");
                Console.WriteLine("");
            }

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("---------------MUESTRA PROVEEDORES-------------------------------");

            foreach (Suppliers supplier in suppliersLogic.GetAll())
            {
                Console.WriteLine($"ID: {supplier.SupplierID} || Nombre de la compañía: {supplier.CompanyName} || Dirección: {supplier.Address} || Fax: {supplier.Fax}");
                Console.WriteLine("");
            }

            Console.WriteLine("--------------------------------------------------------------------");
            Console.ReadLine();
            #endregion

            #region Insertar
            //Insertar Supplier
            suppliersLogic.Add(new Suppliers
            {
                CompanyName = "La Maradona",
                Address = "Segurola y La Habana 4310 7mo  ",
                Phone = "10101010"
            });

            foreach (Suppliers supplier in suppliersLogic.GetAll())
            {
                Console.WriteLine($"Nombre de la compañía: {supplier.CompanyName} || Dirección: {supplier.Address} || Teléfono: {supplier.Phone}");
                Console.WriteLine("");
            }
            Console.ReadLine();
            #endregion

            #region Actualizar
            //Actualizar
            Console.WriteLine("-------------------------PROVEEDORES-------------------------------");

            suppliersLogic.Update(new Suppliers
            {
                SupplierID = 33,
                CompanyName = "Nueva Compañía",
                ContactName = "Diego"
            });

            foreach (Suppliers supplier in suppliersLogic.GetAll())
             {
                Console.WriteLine($"ID: {supplier.SupplierID} || Nombre de la compañía: {supplier.CompanyName} || Dirección: {supplier.Address} || Fax: {supplier.Fax}");
                Console.WriteLine("");
            }
            Console.ReadLine();
            #endregion

            #region Eliminar
            //Borrar
            suppliersLogic.Delete(33);
            Console.ReadLine();
            #endregion

        }
    }
}
