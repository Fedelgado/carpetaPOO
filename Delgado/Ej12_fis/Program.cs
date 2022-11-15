using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12_fis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();
            juego.Jugadores.Add(new Jugador(1));
            juego.Jugadores.Add(new Jugador(2));
            juego.Jugadores.Add(new Jugador(3));

            foreach (string estado in juego.Ronda())
            {
                Console.WriteLine(estado);
            }

            if (juego.FinJuego())
                Console.WriteLine("El juego terminó ya que un jugador murió");
            else 
                Console.WriteLine("El juego continúa");
            Console.ReadKey();
        }
    }
}
