using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_pjt
{
    internal class Prc1

    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int no = int.Parse(Console.ReadLine());

            int rev = 0;

            while (no > 0)
            {
                int digit = no % 10;
                rev = rev * 10 + digit;
                no = no / 10;
            }

            while (rev > 0)
            {
                int digit = rev % 10;

                switch (digit)
                {
                    case 0: Console.Write("Zero "); break;
                    case 1: Console.Write("One "); break;
                    case 2: Console.Write("Two "); break;
                    case 3: Console.Write("Three "); break;
                    case 4: Console.Write("Four "); break;
                    case 5: Console.Write("Five "); break;
                    case 6: Console.Write("Six "); break;
                    case 7: Console.Write("Seven "); break;
                    case 8: Console.Write("Eight "); break;
                    case 9: Console.Write("Nine "); break;
                }

                rev = rev / 10;
            }
        }
    }

}
