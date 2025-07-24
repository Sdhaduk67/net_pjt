using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_pjt
{
    internal class CalMethods
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        public static void Main(string[] args)
        {
            
                int a = 20, b = 10;
                int ra;
                ra = Add(a, b);
                Console.WriteLine("Addtition:" + ra);
                ra = Add(a, b);
                Console.WriteLine("Substraction: {0}", ra);
                ra = Sub(a, b);
        }
    }
}
