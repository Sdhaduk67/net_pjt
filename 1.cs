using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_pjt
{
    internal class _1
    {
        public static void Main (string[] args)
        {
            //Point 1 - According to No of rows
            for (int i = 1; i <= 9; i++)
            {
                //Point 2 - According to No of columns in each row
                int k = i <= 5 ? i : 10 - i;

                for (int j = 1; j <= k; j++)
                {
                    //Point 3 - Dealing with printing
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
