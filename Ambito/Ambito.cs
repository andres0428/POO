using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambito
{
    class Ambito
    {
        private int a = 20;
        public void mostrar()
        {
            int c = 2, r = 0;
            int a = 10;

            r = a * c;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ambito local = {0} ", r);

            r = this.a * c;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ambito local = {0}", r);
        }
    }
}
