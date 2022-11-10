using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej09_fis
{
    public class Cine
    {
        public string pelicula = "Jurassic Park";
        public int precioDeEnt = 300;

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
        
       public string asientoRan()
       {
           string asiento = ""+fila[rd.Next(1,8)]+""+letra[rd.Next(1,9)]+"";
		   return asiento;
       }

    }

    public class Pelicula
    {
        string titulo = "Jurassic Park";
        int duracionMins = 90;
        int edadMin = 15;
        string director = "Joe Johnston";

        public Pelicula()
        {

        }
    }

    public class Espectador 
    {
        string nombre;
		public string Nombre { get {return nombre;}}
        int edad;
		public int Edad { get {return edad;}}
        int dinDisp;
		public int DinDisp { get {return dinDisp;}}
        string asiento;
		public string Asiento { get {return asiento;} set {asiento = value;	}}
        bool puedeSent = false;
        public bool PuedeSent { get {return puedeSent;}}
		
        public Espectador()
        {

        }
		
		public Espectador(string nom, int edad, int din) 
		{
			nombre = nom;
			this.edad = edad;
			dinDisp = din; 
		}
		
		public void Sentarse()
		{
			if(DinDisp > 300 && Edad > 15)
			{
				puedeSent = true;
			}
		}
		
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Asientos asiento = new Asientos();
			List<string> AsientoOcup = new List<string>();
			List<Espectador> espectadores = new List <Espectador>();
			Espectador per1 = new Espectador("Juan", 18, 600);
			Espectador per2 = new Espectador("Juana", 13, 200);
			Espectador per3 = new Espectador("Pedro", 45, 350);
			Espectador per4 = new Espectador("Fede", 19, 800);
			Espectador per5 = new Espectador("Silvia", 5, 50);
			Espectador per6 = new Espectador("Franchesca", 16, 200);
			Espectador per7 = new Espectador("Pablo", 51, 400);
			
			espectadores.Add(per1);
			espectadores.Add(per2);
			espectadores.Add(per3);
			espectadores.Add(per4);
			espectadores.Add(per5);
			espectadores.Add(per6);
			espectadores.Add(per7);
			
			foreach (Espectador espectador in espectadores)
			{
				string AsientoRan = asiento.asientoRan();
				while(AsientoOcup.Contains(AsientoRan))
				{
					AsientoRan = asiento.asientoRan();
				}
				
				AsientoOcup.Add(AsientoRan);
				espectador.Asiento = AsientoRan;
				espectador.Sentarse();
                if (!espectador.PuedeSent)
                {
                    AsientoOcup.Remove(espectador.Asiento);
                }
                else
                {
                    Console.WriteLine($"{espectador.Nombre} esta sentado en el asiento {espectador.Asiento}");
                }
                
			}
            Console.ReadKey();
        }
    }
}