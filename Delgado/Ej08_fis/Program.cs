using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ej08_fis
{
    
    public class Persona
    {
        public static Random rdm = new Random();

        string nombre;
        int edad;
        char sexo;

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

        public Persona()
        {

        }

        public Persona(string nom, int edad, char sexo)
        {
            nombre = nom;
            this.edad = edad;
            this.sexo = comprobarSexo(sexo);
        }

        public Persona(string nom, int edad, char sexo, string materia)
        {
            nombre = nom;
            this.edad = edad;
            this.sexo = comprobarSexo(sexo);
        }
    }

    public class Profesor : Persona
    {

        public bool asist = true;
        Int16 materiaElec = 0;
        string[] materia = { "Matematica", "Filosofia", "Fisica" };
        public bool Asist { get { return asist; } set { asist = value; } }

        public Int16 MateriaElec { get { return materiaElec; } set { materiaElec = value; } }
        public Profesor()
        {

        }

        public Profesor(string nom, int edad, char sexo, Int16 materia) : base(nom, edad, sexo)
        {
            MateriaElec = materia;
        }

        public override void falta()
        {
            int falta = rdm.Next(1, 100);
            if (falta <= 20)
            {
                asist = false;
            }
            else
            {

            }
        }

    }
    public class Alumno : Persona
    {
        bool asist = true;
        int calificacion = rdm.Next(1, 10);
        public bool Asist { get { return asist; } set { asist = value; } }
        public int Calificacion { get { return calificacion; } }
        public Alumno()
        {
        }

        public Alumno(string nom, int edad, char sexo) : base(nom, edad, sexo)
        {

        }

        public override void falta()
        {
            int falta = rdm.Next(1, 100);
            if (falta <= 50)
            {
                Asist = false;
            }
            else
            {

            }
        }
    }
    
    public class Aula
    {
        int aulaId;
        int alFalta; 
        bool darClase = false;
        Int16 materiaElec = 0;
        string[] materia = { "Materia", "Filosofia", "Fisica" };
        int cantMaxEst = 30;
        Profesor profe = new Profesor("Juan", 50, 'H', 0);
        List<Alumno> alumnos = new List<Alumno>(); 
        public int CantMaxEst { get { return cantMaxEst; } set { cantMaxEst = value; } }
        public int AulaId { get { return aulaId; } set { aulaId = value; } }
        public Int16 MateriaElec { get { return materiaElec; } set { materiaElec = value; } }

        public Aula()
        {

        }

        public Aula(int aulaId, Int16 mat)
        {
            AulaId = aulaId;
            MateriaElec = mat;
        }
        
        public void faltasAlumnos()
        {
            int AlFalt = 0;
            foreach(Alumno alumno in alumnos)
            {
                if (alumno.Asist)
                {
                    AlFalt++;
                }
                else { }
            }
            alFalta = AlFalt;
        }

        public void DarClase()
        {
            if (profe.Asist  &&  alFalta < 15 && profe.MateriaElec == MateriaElec)
            {
                darClase = true;
            }
            else
            {
            }
        }
        
        public string MostrarNotas()
        {
            int H = 0;
            int M = 0;
            if (darClase) { 
            foreach (Alumno alumno in alumnos)
            {
                if(alumno.Calificacion > 5)
                {
                    if(alumno.Sexo == 'H')
                    {
                        H++;
                    }else if (alumno.Sexo == 'M')
                    {
                        M++;
                    }
                    else { H++; }
                }
                else{}
                }
            return $"De momento están aprobados {H} hombres y {M} mujeres";
            }
            else
            {
                return "No se puede dar clase";
            }
        }
    }


   
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
    }
    }
}
