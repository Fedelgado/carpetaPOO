using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_del_25_08
{
    class Cuenta
    {
        public Int32 efectivo = 0;
        public Cuenta(Int16 efectivo)
        {
            this.efectivo = efectivo;
        }
        public virtual void extraer(Int16 e)
        {
            if (this.efectivo >= e)
            {
                this.efectivo -= e;
            }
            else
            {
                Console.WriteLine("saldo insuficiente");
            }
        }
    }
    class PlazoFijo : Cuenta
    {
        /*
        public void porcdev()
        {
            if( this.efectivo )
        }*/

        public PlazoFijo(Int16 efectivo) : base(efectivo)
        {
        }

    }

    class CajaAhorro : Cuenta
    {
        public CajaAhorro(Int16 efectivo) : base(efectivo)
        {
        }

    }


    class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(Int16 efectivo) : base(efectivo)
        {

        }

        public override void extraer(Int16 e)
        {
            if ((this.efectivo + 500) >= e)
            {
                this.efectivo -= e;
            }
            else
            {
                Console.WriteLine("saldo insuficiente");
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            int consVal;
            CajaAhorro ca = new CajaAhorro(200);
            CuentaCorriente cc = new CuentaCorriente(1200);

            ca.extraer(100);
            ca.extraer(200);
            //ca.extraer(100);
            cc.extraer(1300);
            cc.extraer(1300);

            Console.WriteLine(ca.efectivo);
            Console.WriteLine(cc.efectivo);
            Console.Write($"Ingresar del que quisieras saber la devolucion en caso de {}");
            //consVal = 
            Console.ReadKey();
        }
    }
}