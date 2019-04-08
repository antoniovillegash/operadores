using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{

    class Mauricio
    {
        public int suma(int a, int b)
        {
            int suma;
            suma = a + b;
            return suma;

        }
        public String mayor(int a, int b)
        {
            string mandar;
            if (a > b)
            {
                mandar = "El numero " + a + " es mayor.";

            }
            else if (b > a)
            {
                mandar = "El numero " + b + " es mayor.";
            }
            else
            {
                mandar = "Son iguales";
            }
            return mandar;
        }
    }
}