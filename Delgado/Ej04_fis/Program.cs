using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ej04_fis
{
    public class Electrodomestico
    {
        float precioBase = 100;
        public float PrecioBase { get { return precioBase; } }

        string color = "blanco";
        public string Color { get { return color; } }

        char consumoEnergetico = 'F';
        public char ConsumoEnergetico { get { return consumoEnergetico; } }

        float peso = 5;
        public float Peso { get { return peso; } set { peso = value; } }

        string[] colores = {"blanco", "negro", "azul", "gris"};
        public Electrodomestico()
        {
        }

        public Electrodomestico( float precio, float peso)
        {
            precioBase = precio;
            this.peso = peso;
        }
        
        public Electrodomestico( float precio, string color, char consumo, float peso)
        {
            precioBase = precio;
            this.color = comprobarCol(color);
            consumoEnergetico = comprobarCons(consumo);
            this.peso = peso;
        }
        private char comprobarCons(char letra)
        {
            if ((int)letra >= 65 &&  (int)letra <= 70)
            {
                return letra;
            }
            else
            {
                return 'F';
            }
        }

        private string comprobarCol(string color)
        {
            if (colores.Contains(color.ToLower()))
            {
                return color;
            }
            else
            {
                return "blanco";
            }
        }

        public virtual float precioFinal()
        {
            float precioFinal = PrecioBase;

            precioFinal += 100 - ((int)this.ConsumoEnergetico - 65) * 20;

            if (Peso >= 0 && Peso < 20) precioFinal += 10;
            else if (Peso >= 20 && Peso < 50) precioFinal += 50;
            else if (Peso >= 50 && Peso < 80) precioFinal += 80;
            else precioFinal += 100;

            return precioFinal;
            
        }
    }
    
    public class Lavadora : Electrodomestico
    {
        int carga = 5;
        public int Carga { get { return carga; } set { carga = value; } }

        public Lavadora()
        {
        }

        public Lavadora(float precio, float peso) : base(peso,  precio)
        { }

        public Lavadora(float precio, string color, char consumo, float peso, int carga) : base(precio, color, consumo, peso)
        {
            Carga = carga;
        }

        public override float precioFinal()
        {
            float precioFinal = PrecioBase;
            if (Carga > 30)
            {
                precioFinal += 50;
            }
            else
            {}
            return precioFinal;
        }
    }

    public class Television : Electrodomestico
    {
        int resolucion = 20;
        bool sintonizadorTDT = false;

        public int Resolucion { get { return resolucion; } }
        public bool SintonizadorTDT { get { return sintonizadorTDT; } }

        public Television()
        {
        }

        public Television(float precio, float peso) : base(peso, precio)
        {
        }

        public Television(float precio, string color, char consumo, float peso, int resolucion, bool sintonizadorTDT) : base(precio, color, consumo, peso)
        {
           this.resolucion = resolucion;
           this.sintonizadorTDT = sintonizadorTDT;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
