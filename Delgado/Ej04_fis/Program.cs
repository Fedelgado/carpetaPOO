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
        public float Peso { get { return peso; } }

        string[] colores = {"blanco", "negro", "azul", "gris"};
        public Electrodomestico()
        {
        }

        public Electrodomestico(int precio, float peso)
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

        public float precioFinal()
        {
            float precioFinal = this.PrecioBase;

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

    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
