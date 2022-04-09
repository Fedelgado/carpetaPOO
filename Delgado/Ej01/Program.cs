
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01
{

    internal class Persona1
    {
        public string nombre;
        public string apellido;
        public int edad;
        public Moto moto;

        public Persona1(string nom, string ap, int ed, Moto mot)
        {
            nombre = nom;
            apellido = ap;
            edad = ed;
            moto = mot;
        }
        public Persona1()
        {
        }
    }
    internal class Persona
    {
        public string nombre;
        public string apellido;
        public int edad;
        public Auto auto;


        public Persona(string nom, string ap, int ed, Auto aut)
        {
            nombre = nom;
            apellido = ap;
            edad = ed;
            auto = aut;
        }
        public Persona()
        {
        }
    }

    internal class Moto
    {
        public string marca;
        public string modelo;
        public string patente;
        public string color;

        public Moto(string mar, string mod, string pat, string col)
        {
            marca = mar;
            modelo = mod;
            patente = pat;
            color = col;
        }

        public Moto(){ 


        }




    }
    internal class Auto
    {
        public string marca;
        public string modelo;
        public string patente;
        public string color;

        public Auto(string mar, string mod, string pat, string col)
        {
            marca = mar;
            modelo = mod;
            patente = pat;
            color = col;
        }
        public Auto()
        {


        }


        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Chevrolet", "Cruze LTZ", "AB738XY", "Plateado");
            Auto auto2 = new Auto("Volkswagen", "Gol", "JHO759", "Rojo");
            Persona per1 = new Persona("Tobias", "Tamashiro", 17, auto1);
            Persona per2 = new Persona("Federico", "Delgado", 17, auto2);
            Persona per3 = new Persona("Eitan", "Mohorade", 63, null);
            Persona1 per4 = new Persona1("Nicolas", "Jaime", 18, new Moto("Suzuki", "GSX250R", "GBU 936", "Negro Grafito"));

            Console.WriteLine($"Hola mi nombre es {per4.nombre} y mi apellido es {per4.apellido}, " +
                $"tengo {per4.edad} años y manejo un {per4.moto.marca}, modelo {per4.moto.modelo}, " +
                $"color {per4.moto.color} y la patente es {per4.moto.patente}");
            Console.ReadKey();
        }


    }
}
