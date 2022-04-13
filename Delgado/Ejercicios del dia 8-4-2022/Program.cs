using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_del_dia_8_4_2022
{
    internal class Persona
    {
        public string nombre;
        public string apellido;
        public DateTime fechaNacimiento;

        public int anios()
        {
            return DateTime.Now.AddTicks(-fechaNacimiento.Ticks).Year;

        }

        public Persona(string nom, string ap, DateTime ed)
        {
            nombre = nom;
            apellido = ap;
            fechaNacimiento = ed;
        }
        public Persona()
        {
        }
        static void Main(string[] args)
        {
            Persona per1 = new Persona("Juan", "Domingo", new DateTime(1995, 4, 24));
            Persona per2 = new Persona("Franco", "Jaurez", new DateTime(1956, 8, 15));
            Persona per3 = new Persona("Bautista", "Jaime", new DateTime(1973, 10, 17));
            Persona per4 = new Persona("Fernando", "De La Fuente", new DateTime(1994, 2, 25));
            Persona per5 = new Persona("Pedro", "Juarez", new DateTime(1967, 11, 27));
            Persona per6 = new Persona("Federico", "Delgado", new DateTime(2005, 1, 30));
            Persona per7 = new Persona("Martin", "Laurnagaray", new DateTime(2002, 5, 28));
            Persona per8 = new Persona("Boris", "Duran", new DateTime(1987, 5, 15));
            Persona per9 = new Persona("Graciela", "Megis", new DateTime(1992, 5, 18));
            List<Persona> Personas = new List<Persona>(); /* Esta es la lista de personas */
            Personas.Add(per1);
            Personas.Add(per2);
            Personas.Add(per3);
            Personas.Add(per4);
            Personas.Add(per5);
            Personas.Add(per6);
            Personas.Add(per7);
            Personas.Add(per8);
            Personas.Add(per9);
            List<int> EdadAd = new List<int>(); /* Aca se guardan las edades de los mayores de edad */
           int SumaEd = 0; /* Aca va a estar la suma de las edades de los mayores para luego ser promediadas */
           int ContEd = 0; /* Aca se guarda la edad del que tenga mayor edad */
           string PersMayor = ""; /* Aca se guarda el nombre del que tenga mayor edad */
            List<Persona> NoCumplio = new List<Persona>(); /* En esta lista van las personas que no cumplieron aún */
            List<Persona> CumpleMayo = new List<Persona>();
            foreach (Persona persona in Personas)
            {
                
                if(persona.fechaNacimiento.Month == new DateTime(2022, 05, 26).Month) /* En este if se evalúa quienes cumplen en el mes de mayo */
                {

                    CumpleMayo.Add(persona);

                }

                if (persona.fechaNacimiento.DayOfYear > DateTime.Now.DayOfYear) /* En este if se agregan a la lista los que no cumplieron aún*/
                {
                    NoCumplio.Add(persona);

                }

                if (persona.anios() > ContEd)  /* Aca hago un comparador para saber quien es el de mayor edad */
                {
                    ContEd = persona.anios();
                    PersMayor = persona.nombre;
                }

                if (persona.anios() > 21)  /* Se guarda las edades de los mayores de edad */
                {
                    EdadAd.Add(persona.anios());
                }

            }
            for (int i = 0; i < EdadAd.Count; i++) /* Se suma a los mayores para luego promediarlos */
            {

                SumaEd = SumaEd + EdadAd[i];

            }


            Console.WriteLine("¿Cual es el promedio de las edades de los mayores de edad?");
            Console.WriteLine("");
            Console.WriteLine($"El promedio de las edades de los mayores de edad es de {SumaEd / EdadAd.Count}"); /* Aca muestra el promedio de las edades*/
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("¿Cual es la persona de mayor edad?");
            Console.WriteLine("");
            Console.WriteLine($"La persona de mayor edad es {PersMayor} con {ContEd} años"); /* Aca se muestra a la persona con mayor edad */
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("¿Cuantas personas todavía no cumplieron años?");
            Console.WriteLine("");
            Console.WriteLine($"{NoCumplio.Count} persona/s todavía no cumplio/cumplieron años"); /* Aca se muestra a la cantidad de personas que todavía no cumplieron años */
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("¿Alguien cumple en mayo?");
            Console.WriteLine("");
            if (CumpleMayo.Any()) /* Aca se comprueba si la lista esta vacía (Proba comentando la parte donde se agregan personas a la lista "CumpleMayo") */
            {
                Console.Write("Si, ");
            }
            else
            {
                Console.WriteLine("No, nadie cumple en mayo");
            }

            for (int i = 0; i < CumpleMayo.Count; i++) /* Aca se muestran a los que cumplen en mayo */
            {
                Console.Write($"{CumpleMayo[i].nombre} {CumpleMayo[i].apellido} cumple en mayo");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }


    }
}
