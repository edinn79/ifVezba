using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifVezba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite vase puno ime");
            string ime = Console.ReadLine();

            Console.WriteLine("Unesite vase godine");
            int godine = int.Parse(Console.ReadLine());

            if (godine < 18)
            {
                Console.WriteLine(ime + " " + "je mladji od 18 godina, maloletan je i nije ozenjen");

            }
            else if (godine == 18)
            {
                Console.WriteLine(ime + " " + "ima tacno 18 godina, punoletan je i nije ozenjen");

            }
            else if (godine > 18 && godine < 90)
            {
                Console.WriteLine(ime + " " + "ima vise od 18 godina, punoletan je i ozenjen je ");
            }

            else
            {
                Console.WriteLine(ime + " " + "ima preko 90 godina i skoro je da umre");
            }


            Console.ReadLine();
        }
    }
}
