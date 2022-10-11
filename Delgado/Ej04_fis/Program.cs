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

        public Lavadora(float precio, float peso) : base(precio,  peso)
        { }

        public Lavadora(float precio, string color, char consumo, float peso, int carga) : base(precio, color, consumo, peso)
        {
            Carga = carga;
        }

        public override float precioFinal()
        {
            float precioFinal = PrecioBase;

            precioFinal += 100 - ((int)this.ConsumoEnergetico - 65) * 20;

            if (Peso >= 0 && Peso < 20) precioFinal += 10;
            else if (Peso >= 20 && Peso < 50) precioFinal += 50;
            else if (Peso >= 50 && Peso < 80) precioFinal += 80;
            else precioFinal += 100;    

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

        public Television(float precio, float peso) : base(precio, peso)
        {
        }

        public Television(float precio, string color, char consumo, float peso, int resolucion, bool sintonizadorTDT) : base(precio, color, consumo, peso)
        {
           this.resolucion = resolucion;
           this.sintonizadorTDT = sintonizadorTDT;
        }

        public override float precioFinal()
        {
            float precioFinal = PrecioBase;

            precioFinal += 100 - ((int)this.ConsumoEnergetico - 65) * 20;

            if (Peso >= 0 && Peso < 20) precioFinal += 10;
            else if (Peso >= 20 && Peso < 50) precioFinal += 50;
            else if (Peso >= 50 && Peso < 80) precioFinal += 80;
            else precioFinal += 100;

            if (Resolucion > 40)
                precioFinal += (30*PrecioBase)/100;

            if (SintonizadorTDT == true)
                precioFinal += 50;

            return precioFinal;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            float sumaElec = 0;
            float sumaLav = 0;
            float sumaTel = 0;
            List<Electrodomestico> listaElec = new List<Electrodomestico>(); 
            Lavadora lav1 = new Lavadora(30, 40);
            Lavadora lav2 = new Lavadora(60, 96);
            Lavadora lav3 = new Lavadora(20, 53);
            Lavadora lav4 = new Lavadora(100, 76);
            Television tel1 = new Television(20, 60);
            Television tel2 = new Television(50, 90);
            Television tel3 = new Television(44, 56);
            Electrodomestico elec1 = new Electrodomestico(86, 36);
            Electrodomestico elec2 = new Electrodomestico(77, 24);
            Electrodomestico elec3 = new Electrodomestico(15, 64);


            listaElec.Add(lav1);
            listaElec.Add(lav2);
            listaElec.Add(lav3);
            listaElec.Add(lav4);
            listaElec.Add(elec1);
            listaElec.Add(elec2);
            listaElec.Add(elec3);
            listaElec.Add(tel1);
            listaElec.Add(tel2);
            listaElec.Add(tel3);



            foreach (Electrodomestico elec in listaElec)
            {
                float precioFinal = elec.precioFinal();
                Console.WriteLine(precioFinal);

                if(elec is Lavadora)
                    sumaLav += precioFinal;
                else if(elec is Television)
                    sumaTel += precioFinal;

                if (elec is Electrodomestico)
                    sumaElec += precioFinal;
            }
            Console.WriteLine($"El precio final de electrodomesticos es de {sumaElec}");
            Console.WriteLine($"El precio final de televisiones es de {sumaTel}");
            Console.WriteLine($"El precio final de lavadoras es de {sumaLav}");
            Console.ReadKey();
        }
    }
}
