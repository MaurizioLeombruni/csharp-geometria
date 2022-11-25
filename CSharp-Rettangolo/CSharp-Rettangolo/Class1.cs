using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Rettangolo
{
    public class Rettangolo
    {
        public string nomeRettangolo = "Nessuno";
        public int baseRettangolo;
        public int altezzaRettangolo;

        public int CalcolaArea()
        {
            return baseRettangolo * altezzaRettangolo;
        }

        public int CalcolaPerimetro()
        {
            return 2 * (baseRettangolo + altezzaRettangolo);
        }

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

        public void DisegnaLatoRettangolo()
        {
            Console.Write("|");
            for (int i = 0; i == baseRettangolo; i++)
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

        public void DisegnaRettangolo()
        {
            DisegnaBaseRettangolo();

            for (int i = 0; i == altezzaRettangolo; i++)
            {
                DisegnaLatoRettangolo();
            }

            DisegnaBaseRettangolo();
        }

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
