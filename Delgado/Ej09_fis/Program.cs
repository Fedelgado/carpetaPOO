using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej09_fis
{
    public class Cine
    {
        string pelicula;
        int precioDeEnt = 500;

        public Cine()
        {

        }

    }

    public class Asientos
    {
        int fila;
        char col;
        bool estaOcup;
        

    }

    public class Pelicula
    {
        string titulo;
        int duracion;
        int edadMin;
        string director;

        public Pelicula()
        {

        }
    }

    public class Espectador 
    {
        string nombre;
        int edad;
        int dinDisp;
        public Espectador()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Asientos asiento = new Asientos();
            Console.WriteLine(asiento.asientoSelec);
            Console.ReadKey();
        }
    }
}
