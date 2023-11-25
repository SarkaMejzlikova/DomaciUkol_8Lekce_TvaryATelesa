using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DomaciUkol_8Lekce_TvaryATelesa
{
    public class Ctverec : ITvar
    {
        double A;

        public Ctverec()
        {
            Console.Write("Zadejte stranu čtverce: ");
            A = Convert.ToInt32(Console.ReadLine());
        }

        public void Obsah()
        {
            double obsah = A * A;
            Console.WriteLine("\nObsah čtverce je " + Math.Round(obsah,2));
        }

        public void Obvod()
        {
            double obvod = 4 * A;
            Console.WriteLine("Obvod čtverce je " + Math.Round(obvod,2) + "\n");
        }
    }
}
