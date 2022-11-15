using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12_fis
{
    internal class Juego
    {
        List<Jugador> jugadorList = new List<Jugador>();
        Revolver revolver = new Revolver();

        public List<Jugador> Jugadores { get { return jugadorList; } set { jugadorList = value; } }
        public Revolver Revolver { get { return revolver; } set { revolver = value; } }


        public bool FinJuego()
        {
            bool jugMuerto = false;
            foreach (Jugador jugador in jugadorList)
            {
                if (jugador.Vivo)
                    jugMuerto = false;
                else
                {
                    jugMuerto = true;
                    break;
                }
            }
            return jugMuerto;
        }

        public List<string> Ronda()
        {
            List<string> estadoDePartida = new List<string>();
            foreach (Jugador jugador in jugadorList)
            {
                jugador.Disparar(revolver);
                if (jugador.Vivo)
                    estadoDePartida.Add($"{jugador.Nombre + jugador.Id} se disparó y no murió");
                else
                    estadoDePartida.Add($"{jugador.Nombre + jugador.Id} se disparó y murió");
            }
                return estadoDePartida;
        }
    }
}
