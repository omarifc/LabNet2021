using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Transporte> transportes = new List<Transporte>(){

                new Avion(1,100),
                new Avion(2,50),
                new Avion(3,30),
                new Avion(4,10),
                new Avion(5,1),
                new Automovil(1, 5),
                new Automovil(2, 4),
                new Automovil(3, 3),
                new Automovil(4, 2),
                new Automovil(5, 1)
            };

            foreach (var item in transportes)
            {
                Console.WriteLine(item.CantPasajeros());
                Console.WriteLine("");
            }

            Console.WriteLine("");

            Avion avionNuevo = new Avion(10,200);
            Console.WriteLine(avionNuevo.alturaVuelo());
            Console.WriteLine(avionNuevo.Avanzar());
            Console.WriteLine(avionNuevo.Detenerse());

            Console.WriteLine("");

            Automovil autoNuevo = new Automovil(18, 3);
            Console.WriteLine(autoNuevo.Avanzar());
            Console.WriteLine(autoNuevo.Detenerse());

            Console.ReadLine();
        }

    }
}
