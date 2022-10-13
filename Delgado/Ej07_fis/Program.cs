using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej07_fis
{
    public class Raices
    {
        double a = 0;
        double b = 0;
        double c = 0;

        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double C { get { return c; } set { c = value; } }

        public Raices(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Raices()
        {
        }

        public string obtenerRaices()
        {
            double raizNeg = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double raizPos = (-b - Math.Sqrt(Math.Pow(b, 2)- 4 * a * c)) / (2 * a);
            return $"Las raíces son {raizNeg} y {raizPos}";
        }

        public string obtenerRaiz()
        {
            double raizNeg = (-b + Math.Sqrt(Math.Pow(b, 2)-4*a*c)) / (2 * a);
            if(Math.Pow(b, 2) - 4 * a * c == 0 ) 
            {
                return $"La raíz es {raizNeg}";
            }
            else
            {
                return "Tiene mas de una raíz";
            }
            
        }

        public double getDiscriminante()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        public bool tieneRaices()
        {
            if (Math.Pow(b, 2) - 4 * a * c > 0)
            {
                return true;
            }
            else 
                return false;
        }

        public bool tieneRaiz()
        {
            if (Math.Pow(b, 2) - 4 * a * c == 0)
            {
                return true;
            }
            else
                return false;
        }

        public string calcular()
        {
            if (tieneRaices())
            {
                obtenerRaices();
            }
            else if (tieneRaiz())
            {
                obtenerRaiz();
            }
            else {
                Console.WriteLine("No tiene soluciones");
            }

            return $"El valor de la Ordenada al Origen es {c}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
