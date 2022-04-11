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
            Persona per6 = new Persona("Federico", "Delgado", new DateTime(2005, 01, 30));
            List<Persona> Personas = new List<Persona>();
            Personas.Add(per1);
            Personas.Add(per2);
            Personas.Add(per3);
            Personas.Add(per4);
            Personas.Add(per5);
            Personas.Add(per6);
            List<int> EdadAd = new List<int>();
            foreach (Persona persona in Personas)
            {

                if (persona.anios() > 21)
                {
                    EdadAd.Add(persona.anios());   
                }

            }
            
        }
    }
}
