using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.OmarSanchezUrra.EF.Data;
using Lab.OmarSanchezUrra.EF.Entities;

namespace Lab.OmarSanchezUrra.EF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;
        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
