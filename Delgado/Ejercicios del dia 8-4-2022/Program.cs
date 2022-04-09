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
            Persona per2 = new Persona("Franco", "Jaurez", new DateTime(2000, 8, 15));
            Persona per3 = new Persona("Bautista", "Jaime", new DateTime(2000, 8, 15));
            Persona per4 = new Persona("Fernando", "De La Fuente", new DateTime(2000, 8, 15));
            Persona per5 = new Persona("", "Jaurez", new DateTime(2000, 8, 15));
        }
    }
}
