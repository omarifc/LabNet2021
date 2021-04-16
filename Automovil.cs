using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPOO
{
    class Automovil : Transporte
    {
        public Automovil(int id, int pasajeros) : base(id, pasajeros)
        {

        }

        public override string Avanzar()
        {
            return "El auto avanza pisando el acelerador";
        }

        public override string Detenerse()
        {
            return "Se detiene pisando el freno";
        }

        public override string CantPasajeros()
        {
            if (getPasajeros() > 1)
            {
                return $"En el automóvil {getId()} viajan {getPasajeros()} pasajeros";
            }
            else
            {
                return $"En el automóvil {getId()} viaja {getPasajeros()} pasajero";
            }
        }

    }
}
