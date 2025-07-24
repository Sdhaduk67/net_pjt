using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_pjt
{
    internal class _2
    {
        public static void Main(string[] args)
        {
            //Point 1 - According to No of rows
            for (int i = 1; i <= 10; i++)
            {
                //Point 2 - According to No of columns in each row
                for (int j = 1; j <= 10; j++)
                {
                    //Point 3 - Dealing with printing
                        int k = i * j;
                        Console.WriteLine(i + "*" + j + " = " + k);
                }
                Console.WriteLine();
            }
        }
    }
}
