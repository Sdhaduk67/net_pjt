using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_pjt
{
    internal class SwapMethods
    {
        static void swap(ref int a,ref int b)
        {
            /*int temp = a;
             a = b;
             b = temp;*/

            // write atomic logic of swapping here
            // a=20 , b=10
            a = a + b;
            b = a - b;
            a = a - b;

        }
        public static void Main (string[] args)
        {
            int a = 20, b = 10;
            Console.WriteLine("Before swap: a={0} and b={1} ",a,b);
            swap(ref a,ref b);//passing argument by value
            Console.WriteLine("After swap: a={0} and b={1}" ,a,b);
        }
    }
}
