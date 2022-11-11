using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10_fis
{
    public class Carta
    {
        sbyte num;
        string palo;
        bool entregada = false;

        public sbyte Numero { get { return num; } }
        public bool Entregada { get { return entregada; } set { entregada = value; } }

        public Carta()
        {
        }
        public Carta(sbyte num, string palo)
        {
            this.num = num;
            this.palo = palo;
        }
    }
}
