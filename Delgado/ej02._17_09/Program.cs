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
        int edad = 0;
        int DNI = 0;
        int peso = 0;
        char sexo = (char) Sexo.H;
        float altura = 0;
       public enum Sexo
        {
            H = 'H', 
            M = 'M'
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
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

        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        

        public Persona(string nom, int edad, char sexo)
        {
            this.sexo = sexo;
            Nombre = nom;
            Edad = edad;
            DNI = 0;
            peso = 0;
            altura = 0;
        }

        public Persona(string nom, int edad, char sex)
        {
            sexo = sex;
            Nombre = nom;
            Edad = edad;
            Dni = dni;
            Peso = peso;
            Altura = altura;
        }

        public Persona()
        { 
        }
        internal class Program
    {
        static void Main(string[] args)
        {
           // Persona pene = new Persona("Inutil", 15, (char) Sexo.H);
        }
    }
}
