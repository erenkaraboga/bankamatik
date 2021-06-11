using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDispenser
{
    class Program
    {
        static void Main(string[] args)
        {

            int select;
            do
            {

                help.showMenu();
                select = Convert.ToInt32(Console.ReadLine());
                help.doSelect(select);
                Console.Beep();

            } while (select != 4);

        }
    }
}

