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
        Random rd = new Random();
        int[] fila = {8,7,6,5,4,3,2,1};
        char[] letra = {'A','B','C','D','E','F','G','H','I'};
        
        public Asientos()
        {
            
        }
        
       public string asientoOcup()
       {
           string asiento = ""+fila[rd.Next(1,8)]+""+letra[rd.Next(1,9)]+"";
		   return asiento;
       }

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
        string asiento;
        bool puedeSent = false;
        
        public Espectador()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Asientos asiento = new Asientos();
           // Console.WriteLine(asiento.asientoSelec);
            Console.ReadKey();
        }
    }
}