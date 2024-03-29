﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10_fis
{
    public class Baraja
    {
        static Random rdm = new Random();
        string[] palos = { "oro", "basto", "espada", "copa" };
        sbyte[] nums = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        /*List<Carta> espadas = new List<Carta>();
        List<Carta> bastos = new List<Carta>();
        List<Carta> copas = new List<Carta>();
        List<Carta> oros = new List<Carta>();*/
        List<Carta> todasCart = new List<Carta>();
        List<Carta> cartasEntreg = new List<Carta>();

        public Baraja()
        {
            rellenarBarajas();
        }

        public void rellenarBarajas()
        {
            foreach (string palo in palos)
            {
                foreach (sbyte num in nums)
                {
                    todasCart.Add(new Carta(num, palo));
                    /*
                    if(palo == "oro")
                    {
                        oros.Add(new Carta(num, palo));
                    }
                    else if(palo == "basto")
                    {
                        bastos.Add(new Carta(num, palo));
                    }
                    else if (palo == "espada")
                    {
                        espadas.Add(new Carta(num, palo));
                    }
                    else if(palo == "copa")
                    {
                        copas.Add(new Carta(num, palo));
                    }*/
                }
            }
        }

        public void barajar()
        {
            for (int i = 0; i < todasCart.Count; i++)
            {
                Carta carta = todasCart[rdm.Next(0, todasCart.Count)];
                while (carta == todasCart[i])
                {
                    carta = todasCart[rdm.Next(0, todasCart.Count)];
                }
                todasCart[i] = carta;
            }
        }

        public Carta SiguienteCarta()
        {
            Carta cartTemp = todasCart[0];
            todasCart[0].Entregada = true;
            todasCart.Remove(todasCart[0]);
            cartasEntreg.Add(cartTemp);

            if (cartTemp == null)
                return null;
            else
            {
                return cartTemp;
            }

        }

        public string CartasDisponibles()
        {
            return $"Aún se pueden repartir {todasCart.Count} cartas";
        }

        public List<Carta> DarCartas()
        {
            Console.WriteLine($"ingrese la cantidad de cartas que quiere:");
            int cant = Convert.ToInt32(Console.ReadLine());
            List<Carta> listaCartas = new List<Carta>();

            for(int i = 0; i < cant; i++)
            {
                listaCartas.Add(todasCart[i]);
                cartasEntreg.Add(todasCart[i]);
                todasCart[i].Entregada = true;
                todasCart.RemoveAt(i);
            }

            return listaCartas;
        }

        public List<Carta> CartasMonton()
        {
           if(cartasEntreg == null)
            {
                return null;
            }
            else
            {
                return cartasEntreg;
            }
        }

        public List<Carta> MostrarBaraja()
        {
            return todasCart;
        }


    }
}
