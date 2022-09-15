using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01._17_09
{
    public class Cuenta
    {
        string titular;          
        double cantidad = 0;

        public string Nombre
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Cuenta(string nom, double cant)
        {
            titular = nom;
            cantidad = cant;
        }

        public void ingresar(double cantIng)
        {
            if (cantIng >= 0)
            {
                cantidad = cantidad + cantIng;
            }
            else
            {
            }
        }

        public void retirar(double cantRet)
        {
            if (cantidad - cantRet < 0)
            {
                cantidad = 0;   
            }
            else
            {
                cantidad = cantidad - cantRet;
            }
        }

        public Cuenta()
        {
        }

        internal class Program
        {
        }
        static void Main(string[] args)
        {
        }
    }
}
