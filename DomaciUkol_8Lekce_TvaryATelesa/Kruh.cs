using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_8Lekce_TvaryATelesa
{
    public class Kruh : ITvar
    {
        double A;

        public Kruh()
        {
            Console.Write("Zadejte poloměr kruhu: ");
            A = Convert.ToInt32(Console.ReadLine());
        }

        public void Obsah()
        {
            double obsah = Math.PI * Math.Pow(A,2);
            Console.WriteLine("\nObsah kruhu je " + Math.Round(obsah, 2));
        }

        public void Obvod()
        {
            double obvod = 2 * Math.PI * A;
            Console.WriteLine("Obvod kruhu je " + Math.Round(obvod, 2) + "\n");
        }
    }
}

