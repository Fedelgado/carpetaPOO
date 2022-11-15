using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12_fis
{
    internal class Jugador
    {
        int id = 1;
        string nombre = "Jugador";
        bool vivo = true;
        public int Id { get { return id; } }
        public string Nombre { get { return nombre; } }
        public bool Vivo { get { return vivo; } }
        public Jugador()
        {

        }

        public Jugador(int id)
        {
            this.id = id;
        }

        public void Disparar(Revolver r)
        {
            if (r.Disparar())
            {
                vivo = false;
            }
            else
            {
                vivo = true;
            }
        }
    }
}
