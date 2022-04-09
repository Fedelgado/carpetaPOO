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
        public int edad;


        public Persona(string nom, string ap, int ed)
        {
            nombre = nom;
            apellido = ap;
            edad = ed;
        }
        public Persona()
        {
        }
        static void Main(string[] args)
        {
            Persona per1 = new Persona("Juan", "");
        }
    }
}
