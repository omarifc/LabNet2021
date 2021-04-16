using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPOO
{
    public class Avion : Transporte, IVolar
    {
        public int altVuelo
        {
            get { return 1000; }
        }

        public Avion(int id, int pasajeros) : base(id, pasajeros)
        {
            
        }

        public override string Avanzar()
        {
            return "Avanzan empujando la palanca";
        }

        public override string Detenerse()
        {
            return "Cuando aterrizan se detienen deslizando la palanca hacia atrás";
        }

        public override string CantPasajeros()
        {
            if (getPasajeros()>1)
            {
                return string.Format("En el avión {0} viajan {1} pasajeros", getId(), getPasajeros());
            }
            else
            {
                return string.Format("En el avión {0} viaja {1} pasajero", getId(), getPasajeros());
            }
            
        }
        public string alturaVuelo()
        {
            return string.Format("Los aviones vuelan a {0} metros de altura", altVuelo);
        }
    }
}
