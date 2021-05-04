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
    public class ProductLogic : LogicBase
    {
        public List<Products> GetProductsSinStock()
        {
            var query = from product in context.Products
                        where product.UnitsInStock == 0 || product.UnitsInStock == null
                        select product;

            return query.ToList();
        }

        public List<Products> GetProductsStockMasDe3()
        {
            var query = context.Products.Where(p => p.UnitPrice >= 3 && p.UnitsInStock != 0 && p.UnitsInStock != null);

            return query.ToList();
        }

        public Products GetProductsId789()
        {
            var query = context.Products.Where(p => p.ProductID == 789);
            return query.FirstOrDefault();
        }
    }
}
