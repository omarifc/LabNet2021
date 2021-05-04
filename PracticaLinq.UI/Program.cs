using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqEntity;
using LinqLogic;
using LinqData;


namespace PracticaLinq.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerLogic customerLogic = new CustomerLogic();
            ProductLogic productLogic = new ProductLogic();

            //  1. Query para devolver objeto customer

                Console.Write($"Ingrese ID del customer: ");
                Customers customer = customerLogic.GetId(Console.ReadLine().ToUpper());

                if (customer == null)
                    Console.WriteLine($"No existe Customer con ese Id");
                else
                    Console.WriteLine($"ID: {customer.CustomerID}\nNombre: {customer.ContactName}\nDirección: {customer.Address}");

            Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");

                Console.ReadKey();

            // 2. Query para devolver todos los productos sin stock
            traerProdSinStock();

            void traerProdSinStock() { 
            Console.WriteLine("Los productos sin stock son los siguientes:\n");
            List<Products> products = productLogic.GetProductsSinStock();

            foreach (Products product in products)
            {
                Console.WriteLine($"ID: {product.CategoryID} || Nombre: {product.ProductName}");
            }
            
            Console.ReadKey();
            };
            

            Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");

            // 3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad
            TraerConStockPrecioMasDe3();

            void TraerConStockPrecioMasDe3() { 

            Console.WriteLine("Los productos con stock y que cuestan mas de 3 son los siguientes:\n");
            List<Products> products = productLogic.GetProductsStockMasDe3();

            foreach (Products product in products)
            {
                Console.WriteLine($"ID: {product.CategoryID} || Nombre: {product.ProductName} || Stock: {product.UnitsInStock} || Precio: {product.UnitPrice}");
            }

                Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");

                Console.ReadKey();
            };
            

            // 4. Query para devolver todos los customers de Washington
            GetCustomersWashington();

            void GetCustomersWashington()
            {
                CustomerLogic customerWashington = new CustomerLogic();

                Console.WriteLine($"Los Customers de Washington son los siguientes: \n");
                List<Customers> customers = customerWashington.GetCustomersWashington();

                foreach (Customers customerWash in customers)
                {
                    Console.WriteLine($"Nombre: {customerWash.CompanyName} || Ciudad: {customerWash.City} || Region: {customerWash.Region}");
                }

                if (customers.Count == 0)
                {
                    Console.WriteLine("No hay customers que pertenezcan a la ciudad de Washington");
                }

                Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");

                Console.ReadKey();
            }


            // 5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789

            Products productoSeleccionado = productLogic.GetProductsId789();

            if (productoSeleccionado == null)
                Console.WriteLine($"No existe Customer con ID 789 \n");
            else
                Console.WriteLine($"ID: {productoSeleccionado.ProductID}\n Nombre: {productoSeleccionado.ProductName}");

            Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");

            Console.ReadKey();

            // 6. Query para devolver los nombre de los Customers.Mostrarlos en Mayuscula y en Minuscula.
            GetNombresCustomers();

            void GetNombresCustomers()
            {
                Console.WriteLine($"Customers en mayuscula y minuscula: \n");
                foreach (var customerNombreMayMin in customerLogic.GetNombreMayusYMinus())
                {
                    Console.WriteLine($"{customerNombreMayMin}\n");
                }

                Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");

                Console.ReadKey();
            }

            // 7. Query para devolver Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1 / 1 / 1997.

            Console.WriteLine($"Los Customers y Orders que son de Washington y mayores a 1/1/1997 son: \n");
            foreach (var customerOrder in customerLogic.GetCustomersOrders())
            {
                Console.WriteLine($"{customerOrder}\n");
            }
            Console.ReadKey();

        }
    }
}
