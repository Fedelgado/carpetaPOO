using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12_fis
{
    internal class Revolver
    {
        static Random rdm = new Random();
        int posicionActual = rdm.Next(0, 7);
        int posicionBala = rdm.Next(0, 7);

        public bool Disparar()
        {
            if (posicionActual == posicionBala)
            {
                siguienteBala();
                return true;
            }
            else
            {
                siguienteBala();
                return false;
            }
        }

        public void siguienteBala()
        {
            if(posicionActual == 6)
                posicionActual = 0;
            else
                posicionActual++;
        }
    }
}
