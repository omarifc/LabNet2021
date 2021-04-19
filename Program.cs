using System;
using ejercicio2;
using ejercicio2.Exceptions;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Consigna 1
            Console.WriteLine("Consigna 1");

            int valor;

            Console.WriteLine("Ingrese un valor: ");
            valor = int.Parse(Console.ReadLine());

            Metodos.Division(valor);

            // Consigna 2
            Console.WriteLine("Consigna 2");

            Metodos.Division();

            // Consigna 3
            Console.WriteLine("Consigna 3");

            try
            {
                Logic.DispararException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} del tipo {ex.GetType()}");
            }
            finally
            {
                Console.WriteLine("Pasamos por el finally!!!!");
            }
            Console.WriteLine("Terminó la consigna 3");
            Console.ReadKey();
            Console.Clear();

            // Consigna 4
            Console.WriteLine("Consigna 4");

            try
            {
                Logic.DispararCustomException();
            }
            catch (CustomExceptions ex)
            {
                Console.WriteLine($"Se capturó la exception custom: '{ex.Message}'");
            }
            finally
            {
                Console.WriteLine("Pasamos por el finally!!!!");
            }

            Console.WriteLine("Terminó la consigna 4");
            Console.ReadKey();

        }
    }
}
