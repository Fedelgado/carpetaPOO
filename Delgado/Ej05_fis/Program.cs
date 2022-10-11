using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05_fis
{
    public class Serie : Entregable
    {
        string titulo = "";
        public string Titulo { get { return titulo; } set { titulo = value; } }

        int numDeTemps = 3;
        public int NumDeTemps { get { return numDeTemps; } set { numDeTemps = value; } }

        bool entregado = false;

        string genero = "";
        public string Genero { get { return genero; } set { genero = value; } }

        string creador = "";
        public string Creador { get { return creador; } set { creador = value; } }
        public Serie()
        {
        }

        public Serie(string tit, string creador)
        {
            Titulo = tit;
            Creador = creador;
        }

        public Serie(string tit, string creador, int numDeTemps, string genero)
        {
            Titulo = tit;
            Creador = creador;
            NumDeTemps = numDeTemps;
            Genero = genero;
        }
        public void Entregar()
        {
            entregado = true;
        }

        public void Devolver()
        {
            entregado = false;
        }

        public bool isEntregado()
        {
            return entregado;
        }

        public bool compareTo(Object e)
        {
            Serie serie = (Serie)e;
            if (serie.NumDeTemps > this.NumDeTemps)
                return true;
            else return false;
        }
    }
     interface Entregable
    {
         void Entregar();
         void Devolver();
         bool isEntregado();
         bool compareTo(Object e);
        
    }
    public class Videojuego : Entregable
    {
        string titulo = "";
        public string Titulo { get { return titulo; } set { titulo = value; } }

        int horasEstimadas = 3;
        public int HorasEstimadas { get { return horasEstimadas; } set { horasEstimadas = value; } }

        bool entregado = false;

        string genero = "";
        public string Genero { get { return genero; } set { genero = value; } }

        string compañia = "";
        public string Compañia { get { return compañia; } set { compañia = value; } }
        public Videojuego()
        {
        }

        public Videojuego(string tit, int horasEstimadas)
        {
            Titulo = tit;
            HorasEstimadas = horasEstimadas;
        }

        public Videojuego(string tit, string compañia, int horasEstimadas, string genero)
        {
            Titulo = tit;
            Compañia = compañia;
            HorasEstimadas = horasEstimadas;
            Genero = genero;
        }

        public void Entregar()
        {
            entregado = true;
        }

        public void Devolver()
        {
            entregado = false;
        }

        public bool isEntregado()
        {
            return entregado;
        }

        public bool compareTo(Object e)
        {
            Videojuego juego = (Videojuego)e;
            if (juego.HorasEstimadas > this.HorasEstimadas)
                return true;
            else return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            int juegosEntregados = 0;
            int seriesEntregadas = 0;
            List<Videojuego> listaJuego = new List<Videojuego>();
            List<Serie> listaSerie = new List<Serie>();

            Videojuego juego1 = new Videojuego("juego", "rockstar", 40, "accion");
            Videojuego juego2 = new Videojuego("juego2", "rockstar", 56, "romance");
            Videojuego juego3 = new Videojuego("juego3", "rockstar", 32, "aventura");
            Videojuego juego4 = new Videojuego("juego4", "rockstar", 47, "misterio");
            Videojuego juego5 = new Videojuego("juego5", "rockstar", 62, "policial");
            Serie serie1 = new Serie("serie", "Hermanos Duffer", 5, "accion");
            Serie serie2 = new Serie("serie2", "Hermanos Duffer", 7, "misterio");
            Serie serie3 = new Serie("serie3", "Hermanos Duffer", 2, "suspenso");
            Serie serie4 = new Serie("serie4", "Hermanos Duffer", 8, "thriller");
            Serie serie5 = new Serie("serie5", "Hermanos Duffer", 1, "terror");

            Videojuego juegoMasLargo = juego1;
            Serie serieMasLarga = serie1;

            juego1.Entregar();
            juego3.Entregar();
            juego5.Entregar();
            serie2.Entregar();
            serie4.Entregar();
            listaJuego.Add(juego1);
            listaJuego.Add(juego2);
            listaJuego.Add(juego3);
            listaJuego.Add(juego4);
            listaJuego.Add(juego5);
            listaSerie.Add(serie1);
            listaSerie.Add(serie2);
            listaSerie.Add(serie3);
            listaSerie.Add(serie4);
            listaSerie.Add(serie5);



            foreach(Serie serie in listaSerie)
            {
               
             if(serie.isEntregado() == true)
                {
                    seriesEntregadas++;
                    serie.Devolver();
                }
                if (serie.compareTo(juegoMasLargo))
                        serieMasLarga = serie;
            }

            foreach(Videojuego juego in listaJuego)
            {
                if (juego.isEntregado() == true)
                {
                    juegosEntregados++;
                    juego.Devolver();
                }
                if (juego.compareTo(juegoMasLargo))
                        juegoMasLargo = juego;
            }

            Console.WriteLine($"el juego mas largo es {juegoMasLargo.Titulo}");
            Console.WriteLine($"la serie mas larga es {serieMasLarga.Titulo}");
            Console.ReadKey();
        }

    }
}