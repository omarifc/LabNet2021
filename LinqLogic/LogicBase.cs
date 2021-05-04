using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqData;


namespace LinqLogic
{
    public abstract class LogicBase
    {
        protected readonly NorthwindContext context;
        protected LogicBase()
        {
            context = new NorthwindContext();
        }

    }
}
