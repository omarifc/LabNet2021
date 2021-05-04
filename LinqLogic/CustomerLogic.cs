using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqEntity;
using LinqData;
using LinqLogic;

namespace LinqLogic
{
    public class CustomerLogic : LogicBase
    {
        public Customers GetId(string id)
        {
            string idCustomer = id.ToString();
            var query = context.Customers.Where(c => c.CustomerID == idCustomer);
            return query.FirstOrDefault();
        }


        public List<Customers> GetCustomersWashington()
        {
            return context.Customers.Where(c => c.Region == "WA").ToList();
        }


        public IQueryable GetNombreMayusYMinus()
        {

            var query = from customer in context.Customers
                        select new
                        {
                            Nombre_en_mayúscula = customer.CompanyName.ToUpper(),
                            Nombre_en_minúscula = customer.CompanyName.ToLower()
                        };

            return query;
        }

        public IQueryable GetCustomersOrders()
        {
            var query = from CU in context.Customers
                        join OR in context.Orders on CU.CustomerID equals OR.CustomerID
                        where CU.Region == "WA" && OR.OrderDate > new DateTime(1997, 1, 1)
                        group CU by CU.CompanyName into CUOR
                        select new
                        { Customer = CUOR.Key , Order = CUOR.Count() };

            return query;
        }
    }
}
