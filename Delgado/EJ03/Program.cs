using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    internal class Program
    {

        internal class Persona
        {
            public List<Hijos> hijos = new List<Hijos>();
            public string nombreP;
            public DateTime fechaNacP;
            public int hijosmay;
            public int hijosnocump;
            public int may50men21;
            public Persona(string nom, DateTime fec)
            {
                nombreP = nom;
                fechaNacP = fec;

            }
            public Persona()
            {

            }
            public int anios()
            {
                return DateTime.Now.AddTicks(-fechaNacP.Ticks).Year;

            }
        }
        internal class Hijos
        {
            public string nombreH;
            public DateTime fechaNacH;

            public Hijos(string nomb, DateTime fech)
            {
                nombreH = nomb;
                fechaNacH = fech;
            }

            public Hijos()
            {

            }
            public int anios()
            {
                return DateTime.Now.AddTicks(-fechaNacH.Ticks).Year;

            }
        }

        static void Main(string[] args)
        {
            int pos = 0;
            List<Persona> persHnocumplio = new List<Persona>();
            List<Persona> persHmas21 = new List<Persona>();
            List<Persona> persMas50Hmas21 = new List<Persona>();
            List<Persona> per = new List<Persona>();

            Persona per1 = new Persona("Juan", new DateTime(1978, 05, 12));
            Persona per2 = new Persona("Nicolas", new DateTime(1975, 11, 28));
            Persona per3 = new Persona("Juana", new DateTime(1963, 07, 22));
            Persona per4 = new Persona("Pedro", new DateTime(1972, 02, 15));
            Persona per5 = new Persona("Valentina", new DateTime(1991, 04, 17));
            Persona per6 = new Persona("Franco", new DateTime(1969, 09, 19));

            Hijos hijo1 = new Hijos("Manuel", new DateTime(1996, 02, 18));
            Hijos hijo2 = new Hijos("Facundo", new DateTime(1999, 05, 02));
            Hijos hijo3 = new Hijos("Federico", new DateTime(2004, 01, 30));
            Hijos hijo4 = new Hijos("Nuhore", new DateTime(2003, 07, 01));
            Hijos hijo5 = new Hijos("Sebastián", new DateTime(2004, 01, 22));
            Hijos hijo6 = new Hijos("Tobias", new DateTime(2001, 08, 24));
            Hijos hijo7 = new Hijos("Paola", new DateTime(1998, 04, 27));
            Hijos hijo8 = new Hijos("Maria", new DateTime(1997, 01, 12));


            per1.hijos.Add(hijo6);
            per1.hijos.Add(hijo2);
            per2.hijos.Add(hijo3);
            per2.hijos.Add(hijo4);
            per3.hijos.Add(hijo5);
            per3.hijos.Add(hijo1);

            per(ran).hijos.Add(hijo2);

            per.Add(per1);
            per.Add(per2);
            per.Add(per3);
            per.Add(per4);
            per.Add(per5);
            per.Add(per6);

            if (per.Count() % 2 == 0)
                pos = per.Count - 1;
            else
                pos = per.Count - 2;

            //pos = ((per.Count() % 2 == 0) ? per.Count - 1 : per.Count - 2);

            for (int i = pos; i >= 0; i-=2)
            {
                per.Remove(per[i]);
            }


            foreach (Persona persona in per)
            {
                foreach (Hijos hijo in persona.hijos)
                {

                    if (hijo.anios() > 21)
                    {
                        persona.hijosmay++;
                    }

                    if (hijo.fechaNacH.DayOfYear < DateTime.Now.DayOfYear)
                    {
                        persona.hijosnocump++;
                    }

                       
                        if (hijo.anios() > 21 && persona.anios() > 50)
                        {

                            persona.may50men21++;

                    }
                    else
                    {

                    }





                }

            }

            per[new Random().Next(0, per.Count - 1)].hijos.Add(hijo7);
            //per[rand.Next(0, per.Count - 1)].hijos.Add(hijo7);

            foreach (Persona pers in per)
            {
                Console.WriteLine($"{pers.nombreP} tiene mas de 50 años y tiene {pers.may50men21} hij@/s mayores de 21");
                Console.WriteLine($"{pers.nombreP} tiene {pers.hijosmay} hijos mayores de 21 años");
                Console.WriteLine($"{pers.nombreP} tiene {pers.hijosnocump} hijos que todavía no cumplieron años");
            }
            /*Console.WriteLine($"{per3.nombreP} tiene mas de 50 años y tiene {per3.may50men21} hij@/s mayores de 21");
            Console.WriteLine($"{per3.nombreP} tiene {per3.hijosmay} hijos mayores de 21 años");
            Console.WriteLine($"{per3.nombreP} tiene {per3.hijosnocump} hijos que todavía no cumplieron años");*/
            Console.ReadKey();

        }
    }
}
