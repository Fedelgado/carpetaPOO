using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11_fis
{
    internal class Partido
    {
        static Random rdm = new Random();
        int equipo1 = rdm.Next(0, 11);
        int equipo2 = rdm.Next(0,11);

        public int Equipo1 { get { return equipo1; } }
        public int Equipo2 { get { return equipo2; } }

        public void resetearPartidos()
        {
            equipo1 = rdm.Next(0, 11);
            equipo2 = rdm.Next(0, 11); 
        }
    }
}
