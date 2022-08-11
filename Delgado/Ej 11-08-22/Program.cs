using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    class Persona
    {
        public string nombre;
        public string apellido; 
        public DateTime fechaNac;
        public int anios;
        public Persona(int edad,  string nombre, string apellido, DateTime fechaNac)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.anios = edad;
        }



        public int edad()
        {
            return DateTime.Now.AddTicks(-fechaNac.Ticks).Year;
        }

        public int edad (int dias)
        {
            
            if (fechaNac.DayOfYear + dias < DateTime.Now.DayOfYear)
            {
                return DateTime.Now.AddTicks(-fechaNac.Ticks).Year;
            }
            else if (fechaNac.DayOfYear + dias > DateTime.Now.DayOfYear)
            {
                return DateTime.Now.AddTicks(-fechaNac.Ticks).Year + 1;
            }
            else
            {
                return 0;
            }
        }

    }

    class Program
    {
        static Persona o;
        static List<Persona> lista = new List<Persona>();
        /*
        static Persona averiguarMenor(List<Persona> listatemp)
        {
            //o = new Persona

            Persona temp  = new Persona(999, "x", "x");
            foreach (Persona p in lista)
            {
                if (p.edad < temp.edad)
                {
                    temp = p;
                }
            }
            return temp;
        }
        */

        static void Main(string[] args)
        {
            int suma = 0, promedio = 0;
            int cantMayores = 0;

            lista.Add(new Persona(20, "Pablo", "Perez", new DateTime(2000, 11, 2)));
            lista.Add(new Persona(25, "Juan", "Suarez", new DateTime(2003, 10, 2)));
            lista.Add(new Persona(30, "Analia", "Gomez", new DateTime(2020, 08, 6)));

            Console.WriteLine(lista[0].edad());
            Console.WriteLine(lista[0].edad(3));

            Console.WriteLine(lista[1].edad());
            Console.WriteLine(lista[1].edad(4));

            Console.WriteLine(lista[2].edad());
            Console.WriteLine(lista[2].edad(10));



            /*
                        for(int i = 0; i < lista.Count; i++)
                        {
                            if (lista[i].edad > 21)
                            {
                                cantMayores++;
                                suma += lista[i].edad;
                            }
                        }
                        promedio = suma / cantMayores;
                        Console.WriteLine(promedio);


                        o = averiguarMenor(lista);
                        Console.WriteLine(o.nombre);

                        int menor = 999;
                        for (int i = 0; i < lista.Count; i++)
                        {
                            if (lista[i].edad < menor)
                            {
                                menor = lista[i].edad;
                                o = lista[i];
                            }
                        }


                        Console.WriteLine(o.nombre + " edad " + o.edad);

                        promedio = suma / cantMayores;
                        Console.WriteLine(promedio);
            */


            Console.ReadKey();

        }
    }
}
