using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Geometria
{
    public class Rettangolo
    {
        public string nomeRettangolo = "Nessuno";
        public int baseRettangolo;
        public int altezzaRettangolo;

        //Calcola l'area del rettangolo. (base * altezza)
        public int CalcolaArea()
        {
            return baseRettangolo * altezzaRettangolo;
        }

        //Calcola il perimetro del rettangolo. 2*base + 2*altezza, o 2*(base+altezza).
        public int CalcolaPerimetro()
        {
            return 2 * (baseRettangolo + altezzaRettangolo);
        }

        //Disegna la parte orizzontale del rettangolo. Ogni unità equivale a 2 trattini.
        //Quando arriva all'ultimo elemento, va a capo.
        public void DisegnaBaseRettangolo()
        {
            for (int i = 0; i <= baseRettangolo; i++)
            {
                if (i < baseRettangolo)
                {
                    Console.Write("--");
                }
                else
                {
                    Console.WriteLine("--");
                }
            }
        }

        //Disegna un pezzo di lato del rettangolo; una unità è un simbolo |.
        //Poi mette spazi vuoti in base alla base del rettangolo, e finisce con un altro simbolo |.
        public void DisegnaLatoRettangolo()
        {
            Console.Write("|");
            for (int i = 0; i <= baseRettangolo; i++)
            {
                if (i < baseRettangolo)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.WriteLine("|");
                }
            }
        }

        //Disegna una base, poi un pezzo di lato per unità di altezza, e infine l'altra base.
        public void DisegnaRettangolo()
        {
            DisegnaBaseRettangolo();

            for (int i = 0; i <= altezzaRettangolo; i++)
            {
                DisegnaLatoRettangolo();
            }

            DisegnaBaseRettangolo();
        }

        //Stampa le informazioni del rettangolo.
        public void StampaDettagliRettangolo()
        {
            int rettangoloArea = CalcolaArea();
            int rettangoloPerim = CalcolaPerimetro();

            Console.WriteLine("-- Dettagli del rettangolo: ");
            Console.WriteLine("Nome del rettangolo: " + nomeRettangolo);
            Console.WriteLine("Base: " + baseRettangolo);
            Console.WriteLine("Altezza: " + altezzaRettangolo);
            Console.WriteLine("Area: " + rettangoloArea);
            Console.WriteLine("Perimetro: " + rettangoloPerim);
        }
    }
}
