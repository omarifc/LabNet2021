using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio2.Exceptions
{
    public class CustomExceptions : Exception
    {
        public CustomExceptions() : base("Mensaje de error de nuestra custom exception") { }

    }
}
