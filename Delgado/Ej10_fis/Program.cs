using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10_fis
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Baraja baraja = new Baraja();
            baraja.barajar();
            Console.WriteLine(baraja.SiguienteCarta().Numero);
            Console.ReadKey();  
        }
    }
}
