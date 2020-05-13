using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            CCalculadora cCalculadora = new CCalculadora { a = 10, b = 20 };
            cCalculadora.sumador();
            cCalculadora.imprimir();

            CCalculadora cCalculadora1 = new CCalculadora {a = 34, b = 55 };
            cCalculadora1.sumador();
            cCalculadora1.imprimir();

            Console.ReadKey();
            
        }
    }
}
