using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPOO
{
    public abstract class Transporte
    {
        private int id;
        private int pasajeros;
        
        protected Transporte(int id, int pasajeros)
        {
            this.id = id;
            this.pasajeros = pasajeros;
        }

        public int getPasajeros() {
            return pasajeros;
        }

        public int getId() {
            return id;
        }

        public abstract string CantPasajeros();

        public abstract string Avanzar();

        public abstract string Detenerse();

    }
}
