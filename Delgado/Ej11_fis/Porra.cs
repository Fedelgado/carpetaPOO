using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11_fis
{
    internal class Porra
    {
        int pozoActual = 0;
        int pozoAcumul = 0;
        List<Jugador> jugadoresGanadores = new List<Jugador>();
        public int PozoAcumul { get { return pozoAcumul; } set { pozoAcumul = value; } }
        public int PozoActual { get { return pozoActual; } set { pozoActual = value; } }
        public List<Jugador> JugadoresGanadores { get { return jugadoresGanadores; } set { jugadoresGanadores = value; } }


        public void comprobarJugadores(List<Jugador> jugadores, List<Partido> jornada)
        {
            foreach (Jugador jugador in jugadores)
            {
                foreach(Partido partido in jornada)
                if(jugador.Apuestaeq1 == partido.Equipo1 && jugador.Apuestaeq2 == partido.Equipo2)
                {
                    jugador.PartidosAcertados++;
                }

                if(jugador.PartidosAcertados >= 2)
                {
                    jugadoresGanadores.Add(jugador);
                    jugador.Ganador = true;
                    jugador.JornadasGanadas++;

                }
                jugador.PartidosAcertados = 0;
            }
        }

        public string repartirPremioONo(List<Jugador> jugadoresGanadores)
        {
            if(jugadoresGanadores.Count() >= 1)
            {
                float porcionParaCadaJug = (pozoActual + pozoAcumul) / jugadoresGanadores.Count;
                foreach (Jugador jugador in jugadoresGanadores)
                {
                    jugador.Dinero += porcionParaCadaJug;
                    jugador.Ganador = false;
                }
                pozoActual = 0;
                return $"El/Los jugador/es ganador/es es/son {jugadoresGanadores.Count()} y se lleva/cada uno se lleva {porcionParaCadaJug} euros";
            }
            else
            {
                pozoAcumul += pozoActual;
                return $"Nadie ganó la apuesta";
            }
        }
    }
}
