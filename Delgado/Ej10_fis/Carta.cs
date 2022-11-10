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
