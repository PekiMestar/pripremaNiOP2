using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaNiOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst, konacno;

            Console.WriteLine("Napišite neku riječ: ");
            tekst = Console.ReadLine();

            if (tekst.Length <= 5)
            {
                Console.WriteLine(tekst);
            }

            else if (tekst.Length > 5)
            {
                konacno = tekst.Substring(2, tekst.Length - 5);

                Console.WriteLine(konacno);
            }

            Console.ReadKey();
        }   
    }
}
