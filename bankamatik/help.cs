using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDispenser
{
    class help
    {
       
        private static int Budget=0;

        #region Encapsulation
        public int _budget
        {
            get
            {

                return Budget;
            }
            set
            {

                Budget = value;

            }

        }
        #endregion

        #region 
        public static void showMenu()
        {
            Console.WriteLine("---------WELCOME---------");
            Console.WriteLine("Please Select");
            Console.WriteLine("1-Show Budget\n2-Deposit Money\n3-Withdraw Money\n4-Exit");

        }

        public static void doSelect(int a)
        {
            if (a == 1)
            {
                Console.WriteLine("Budget {0}", Budget);


            }
            if (a == 2)
            {
                Console.WriteLine("Please Write Deposit Money");
                Budget += depositMoney();

            }

            if (a == 3)
            {
                Console.WriteLine("Please Write Withdraw Money");

                int c = withdrawMoney();
                if (Budget >= c)
                {
                    Budget -= c;
                }
                else
                {
                    Console.WriteLine("No Limit");
                    Console.WriteLine("Do You Want To Get Into The Minus? 1/2");
                    int s2 = int.Parse(Console.ReadLine());
                    if (s2 == 1)
                    {
                        Budget -= c;

                    }
                    else
                    {
                        return;

                    }
                }
            }

            if (a == 4)
            {
                Console.WriteLine("Exiting");
            }

        }
        private static int depositMoney()
        {
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        private static int withdrawMoney()
        {
            int x = int.Parse(Console.ReadLine());
            return x;
        }

        #endregion

    }
}

