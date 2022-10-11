using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej06_fis
{
    public class Libro
    {
        int Isbn = 0;
        public int ISBN { get { return Isbn; } set { Isbn = value; } }

        string titulo = "";
        public string Titulo { get { return titulo; } set { titulo = value; } }

        string autor = "";
        public string Autor { get { return autor; } set { autor = value; } }

        int numDePag = 0;
        public int NumDePag { get { return NumDePag; } set { numDePag = value; } }

        public Libro()
        {
        }

        public Libro(int isbn, string titulo, string autor, int numdepag)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            NumDePag = numdepag;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro(1235123, "titulo1", "autor1", 40);
            Libro libro2 = new Libro(1256544, "titulo2", "autor2", 56);
            List<Libro> listLibro = new List<Libro>();
            listLibro.Add(libro1);
            listLibro.Add(libro2);

            Libro libroConMasPag = libro1;
            foreach(Libro libro in listLibro)
            {
                if(libro.NumDePag > libroConMasPag.NumDePag)
                {
                    libroConMasPag = libro;
                }
            }

            Console.WriteLine($"El libro con mas páginas es {libroConMasPag.Titulo}");
        }
    }
}
