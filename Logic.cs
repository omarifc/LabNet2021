using ejercicio2.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio2
{
    class Logic
    {

        public static void DispararException()
        {
            throw new Exception();
        }

        public static void DispararCustomException()
        {
            throw new CustomExceptions();
        }
    }
}
