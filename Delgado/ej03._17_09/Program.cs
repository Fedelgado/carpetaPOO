using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03._17_09
{
    public class Password
    {
        int longitud = 8;
        string contraseña;

        public int Longitud
        {
            get { return longitud; }
            set { longitud = value; }

        }

        public string Contraseña
        {
            get { return contraseña; }

        }


        public Password()
        {
        }

        public Password(int longit)
        {
            this.longitud = longit;
            contraseña = generarPassword();
            
        }
        public bool esFuerte()
        {
            int mayusc = 0;
            int minusc = 0;
            int num = 0;
            for(int i = 0; i < longitud; i++)
            {             
                if (Char.IsUpper(contraseña[i]))
                {
                    mayusc++;
                }

                if (Char.IsNumber(contraseña[i]))
                {
                    num++;
                }

                if (Char.IsLower(contraseña[i]))
                {
                    minusc++;
                }
            }

            if (mayusc > 2 && minusc > 1 && num > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string generarPassword()
        {

            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string contraseña = String.Empty;
            char letra;
            Random ran = new Random();
            for (int i = 0; i < longitud; i++)
            {
                letra = caracteres[ran.Next(caracteres.Length)];
                contraseña += letra.ToString();
            }
            return contraseña;


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Password> contraseñas = new List<Password>();
            List<bool> esFuerteOno = new List<bool>();
            Console.WriteLine("Cuantas contraseñas quiere crear? ingrese un numero: ");
            int cantCont = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud, en numeros, que quiere para las contraseñas: ");
            int longCont = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantCont; i++)
            {
                Password contra = new Password(longCont);
                contraseñas.Add(contra);
                esFuerteOno.Add(contra.esFuerte());
                if(esFuerteOno[i] == true)
                {
                    Console.WriteLine($"La contraseña es {contraseñas[i].Contraseña} y es fuerte");
                }
                else
                {
                    Console.WriteLine($"La contraseña es {contraseñas[i].Contraseña} y no es fuerte");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
