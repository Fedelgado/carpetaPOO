using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11_fis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> listaJugadores = new List<Jugador>();
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador();
            Jugador jugador3 = new Jugador();
            Jugador jugador4 = new Jugador();
            Jugador jugador5 = new Jugador();
            Jugador jugador6 = new Jugador();
            Jugador jugador7 = new Jugador();
            Jugador jugador8 = new Jugador();
            listaJugadores.Add(jugador1);
            listaJugadores.Add(jugador2);
            listaJugadores.Add(jugador3);
            listaJugadores.Add(jugador4);
            listaJugadores.Add(jugador5);
            listaJugadores.Add(jugador6);
            listaJugadores.Add(jugador7);
            listaJugadores.Add(jugador8);

            List<Partido> jornada = new List<Partido>();
            Partido partido1 = new Partido();
            Partido partido2 = new Partido();
            Partido partido3 = new Partido();
            Partido partido4 = new Partido();
            Partido partido5 = new Partido();
            Partido partido6 = new Partido();
            Partido partido7 = new Partido();
            Partido partido8 = new Partido();
            Partido partido9 = new Partido();
            Partido partido10 = new Partido();
            jornada.Add(partido1);
            jornada.Add(partido2);
            jornada.Add(partido3);
            jornada.Add(partido4);
            jornada.Add(partido5);
            jornada.Add(partido6);
            jornada.Add(partido7);
            jornada.Add(partido8);
            jornada.Add(partido9);
            jornada.Add(partido10);

            Porra porra = new Porra();
        
            foreach(Jugador jugador in listaJugadores)
            {
                jugador.Apostar(porra);
            }

            porra.comprobarJugadores(listaJugadores, jornada);

            Console.WriteLine(porra.repartirPremioONo(porra.JugadoresGanadores));

            foreach (Partido partido in jornada)
            {
                partido.resetearPartidos();
            }

            foreach (Jugador jugador in listaJugadores)
            {
                jugador.Apostar(porra);
            }

            porra.comprobarJugadores(listaJugadores, jornada);
            Console.WriteLine(porra.repartirPremioONo(porra.JugadoresGanadores));

            for(int i = 0; i < listaJugadores.Count; i++)
            {
                Console.WriteLine($"el jugador{i} ganó {listaJugadores[i].JornadasGanadas} jornadas y tiene {listaJugadores[i].Dinero} euros");
            }

            Console.ReadKey();


        }
    }
}
