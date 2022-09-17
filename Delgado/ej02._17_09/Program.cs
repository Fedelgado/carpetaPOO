using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej02._17_09
{
    public class Persona
    {
        string nombre = "";
        Int16 edad = 0;
        int DNI = 0;
        float peso = 0;
        char sexo = 'H';
        float altura = 0;

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Int16 Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int Dni
        {
            get { return DNI; }
            set { DNI = value; }
        }

        public float Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public int calcularIMC()
        {
            if (Peso / (Altura * Altura) < 20)
            {
                return -1;
            }
            else if (Peso / Math.Pow(Altura, 2) >= 20 && Peso / Math.Pow(Altura, 2) <= 25)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public bool esMayorDeEdad()
        {
            if (Edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private char comprobarSexo(char sexo)
        {
            if (sexo == 'H' || sexo == 'M')
            {
                return sexo;
            }else
            {
                return 'H';
            }
        }

        private int generarDNI()
        {
            Random ran = new Random();
            int rd = ran.Next(0, 70000000);
            return rd;
        }

        public Persona(string nom, Int16 edad, char sexo)
        {
            Sexo = sexo;
            Nombre = nom;
            Edad = edad;
            DNI = 0;
            peso = 0;
            altura = 0;
        }

        public Persona(string nom, Int16 edad, char sex, float peso, float altura)
        {
            Sexo = comprobarSexo(sex);
            Nombre = nom;
            Edad = edad;
            Dni = generarDNI();
            Peso = peso;
            Altura = altura;
        }

        public Persona()
        {
        }
    }
        internal class Program
    {


            static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese la cantidad de personas que desea crear: ");
            int cantPer = Convert.ToInt32(Console.ReadLine());
            List<Persona> persList = new List<Persona>();
            for (int i = 1; i < cantPer + 1; i++)
            {

                Console.WriteLine($"Ingrese el nombre de la persona n° {i}: ");
                string nom = Console.ReadLine();
                Console.WriteLine($"Ingrese la edad de la persona n° {i}: ");
                Int16 edad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine($"Ingrese el peso en kg de la persona n° {i}: ");
                float peso = float.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese la altura en metros de la persona n° {i}: ");
                float altura = float.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese el sexo de la persona n° {i} (H si es Hombre, M si es mujer): ");
                char sexo = Convert.ToChar(Console.ReadLine());
                persList.Add(new Persona(nom, edad, sexo, peso, altura)); 
                /* en esta parte no sabía que hacer, porque la consigna dice 
               "Crea 3 objetos de la clase anterior, el primer objeto obtendrá las anteriores variables pedidas por teclado,
                el segundo objeto obtendrá todos los anteriores menos el peso 
                y la altura y el último por defecto, para este último utiliza los métodos set para darle a los atributos un valor" 
                pero no sé como hacer para que cuando una variable no tiene un valor asignado no la tome, por eso lo deje así.*/
            }

            foreach (Persona pers in persList)
            {
                bool mayorDeEdad = pers.esMayorDeEdad();
                Console.WriteLine("");
                if (pers.calcularIMC() == -1) 
                {
                    Console.WriteLine("Esta persona esta por debajo de su peso ideal");
                }else if (pers.calcularIMC() == 0) 
                {
                    Console.WriteLine("Esta persona esta en su peso ideal");
                }
                else
                {
                    Console.WriteLine("Esta persona esta por encima de su peso ideal");
                }


                if (mayorDeEdad)
                    Console.WriteLine("Esta persona es mayor de edad");
                else
                    Console.WriteLine("Esta persona no es mayor de edad"); //Y no, no me olvide las llaves, no las puse cuando es un una línea no hace falta
                

                Console.WriteLine($"Se llama {pers.Nombre} tiene {pers.Edad} años, su DNI es {pers.Dni}, " +
                    $"es {pers.Sexo} (H hombre, M mujer), mide {pers.Altura} metros y pesa {pers.Peso} kg");
            }
            Console.ReadKey();
            // Persona pene = new Persona("Inutil", 15, (char) Sexo.H);
        }
    }
}
