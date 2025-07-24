using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_pjt
{
    internal class _3
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int res = ++a + b++ + b++ + a++ + ++a + ++b + a++; //10
            /*a = a +1;
            b = b + 1;*/
            Console.WriteLine(res); // 16
        }
    }
}
