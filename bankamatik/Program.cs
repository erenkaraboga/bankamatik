using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankamatik
{
    class Program
    {
        static void Main(string[] args)
        {

            int secim;
            do
            {

                help.menuGoster();
                secim = Convert.ToInt32(Console.ReadLine());
                help.secimYap(secim);
                Console.Beep();

            } while (secim != 4);

        }
    }
}
