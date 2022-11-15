using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11_fis
{
    internal class Jugador
    {
        static Random rdm = new Random();
        float dinero = 20;
        int apuestaeq1 = 0; 
        int apuestaeq2 = 0;
        int partidosAcertados = 0;
        bool ganador = false;
        int jornadasGanadas = 0;

        public int JornadasGanadas { get { return jornadasGanadas; } set { jornadasGanadas = value; } }
        public int PartidosAcertados { get { return partidosAcertados; } set { partidosAcertados = value; } }
        public float Dinero { get { return dinero; } set { dinero = value; } }
        public int Apuestaeq1 { get { return apuestaeq1; } set { apuestaeq1 = value; } }
        public int Apuestaeq2 { get { return apuestaeq2; } set { apuestaeq2 = value; } }
        public bool Ganador { get { return ganador; } set { ganador = value; } }
        public void Apostar(Porra porra)
        {
            if(dinero > 0)
            {
                apuestaeq1 = rdm.Next(0, 11);
                apuestaeq2 = rdm.Next(0, 11);
                dinero--;
                porra.PozoActual++;
            }
            else { }

        }



    }
}
