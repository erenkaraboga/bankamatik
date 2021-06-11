using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDispanser
{
    class Program
    {
        static void Main(string[] args)
        {

            int select;
            do
            {

                help.showmenu();
                select = Convert.ToInt32(Console.ReadLine());
                help.secimYap(select);
                Console.Beep();

            } while (select != 4);

        }
    }
}
