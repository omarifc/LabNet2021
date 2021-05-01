using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.OmarSanchezUrra.EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T algo);

        void Delete(int id);

        void Update(T algo);
    }
}
