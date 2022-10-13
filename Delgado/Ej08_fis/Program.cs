using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej08_fis
{
    public class Aula
    {
        string nombre;
        int edad;
        char sexo;
        string materia;
        public string Nombre { get { return nombre; } }
        public int Edad { get { return edad; } }
        public char Sexo { get { return sexo; } }
        private char comprobarSexo(char sexo)
        {
            if (sexo == 'H' || sexo == 'M')
            {
                return sexo;
            }
            else
            {
                return 'H';
            }
        }

        public virtual void falta()
        {

        }
        
        public Aula()
        {

        }

        public Aula(string nom, int edad, char sexo)
        {
            nombre = nom;
            this.edad = edad;
            this.sexo = comprobarSexo(sexo);
        }

        public Aula(string nom, int edad, char sexo, string materia)
        {
            nombre = nom;
            this.edad = edad;
            this.sexo = comprobarSexo(sexo);   
            this.materia = materia;
        }
    }

    public class Profesor : Aula
    {
        
        static Random rdm = new Random();
        int inasist = 0;
        public Profesor()
        {

        }

        public Profesor(string nom, int edad, char sexo, string materia) : base(nom, edad, sexo, materia)
        {
            
        }

        public override void falta()
        {
            int falta = rdm.Next(1, 100);
              if (falta <= 20)
            {
                inasist++;
            }
            else
            {

            }
        }

    }

    public class Alumno : Aula
    {
        int calificacion;
        public int Calificacion { get { return calificacion; } }
        public Alumno()
        {
        }

        public Alumno(string nom, int edad, char sexo, int calif) : base(nom, edad, sexo)
        { 
            this.calificacion= calif;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
