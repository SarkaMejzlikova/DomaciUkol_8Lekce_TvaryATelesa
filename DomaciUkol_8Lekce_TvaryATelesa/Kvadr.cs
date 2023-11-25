using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DomaciUkol_8Lekce_TvaryATelesa
{
    public class Kvadr : ITeleso
    {
        double A;
        double B;
        double C;

        public Kvadr()
        {
            Console.Write("Zadejte délku: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte šířku: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte výšku:");
            C = Convert.ToInt32(Console.ReadLine());
        }


        public void Objem()
        {
            double objem = A * B * C;
            Console.WriteLine("\nObjem kvádru je " + Math.Round(objem, 2));
        }

        public void Povrch()
        {
            double povrch = 2 * (A * B + B * C + A * C);
            Console.WriteLine("Povrch kvádru je " + Math.Round(povrch, 2) + "\n");
        }
    }
}
