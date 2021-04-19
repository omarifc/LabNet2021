using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio2
{
    public static class Metodos
    {

        public static void Division(this int num) {

            double resultado;

            try
            {
                resultado = num / 0;

            }
            catch (DivideByZeroException ex)
            {
                
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("El programa ha finalizado");
            }
            Console.WriteLine("Terminó la consigna 1");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Division() {

            int num1, num2;
            double resultado;

            try
            {
                Console.WriteLine("Ingrese el dividendo: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el divisor: ");
                num2 = int.Parse(Console.ReadLine());

                resultado = num1 / num2;
                Console.WriteLine(string.Format("El resultado de la división es: {0}", resultado));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(string.Format("Ingresó un valor inválido o nada!!"));
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(string.Format("Quién te enseñó matemáticas papu? no se puede dividir por 0"));
            }
            finally
            {
                Console.WriteLine("El programa ha finalizado");
            }
            Console.WriteLine("Terminó la consigna 2");
            Console.ReadKey();
            Console.Clear();
        }


    }
}
