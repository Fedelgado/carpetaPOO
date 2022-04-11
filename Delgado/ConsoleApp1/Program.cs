using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public DateTime fechaNacimiento;


        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int anios()
        {
            DateTime date = DateTime.Now;
            if (date.DayOfYear < fechaNacimiento.DayOfYear)
            {
                return 2022 - fechaNacimiento.Year - 1;

            }
            else {
                return 2022 - fechaNacimiento.Year;


            }
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Persona per1;

            per1 = new Persona("federicogay", "delgadogay", new DateTime(2001, 4, 10));

            Console.WriteLine("{0} tiene {1} años", per1.nombre, per1.anios());
            Console.WriteLine(per1.nombre + " tiene " + per1.anios() + " años");
            Console.WriteLine($"{per1.nombre} tiene {per1.anios()} años");
            Console.ReadKey();
        }
    }
}
