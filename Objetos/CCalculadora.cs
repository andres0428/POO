using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class CCalculadora
    {
        public double a, b, r;

        public void sumador()
        {
            r = a + b;
        }

        public void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("La suma del número {0} y del número {1} = {2},",a, b, r);
        }
    }    
}

