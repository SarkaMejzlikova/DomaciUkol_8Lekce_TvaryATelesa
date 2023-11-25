using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_8Lekce_TvaryATelesa
{
    public class Valec : ITeleso
    {
        double A;
        double B;

        public Valec()
        {
            Console.Write("Zadejte poloměr: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte výšku: ");
            B = Convert.ToInt32(Console.ReadLine());
        }

        public void Objem()
        {
            double objem = Math.PI * Math.Pow(A,2) * B;
            Console.WriteLine("\nObjem válce je " + Math.Round(objem, 2));
        }

        public void Povrch()
        {
            double povrch = (2 * Math.PI * Math.Pow(A, 2)) + (2 * Math.PI * A * B);
            Console.WriteLine("Povrch kvádru je " + Math.Round(povrch, 2) + "\n");
        }
    }
}
