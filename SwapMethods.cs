using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_pjt
{
    /// <summary>
    /// This class includes important.methods
    /// </summary>
    internal class SwapMethods
    {
        /// <summary>
        /// used to share % value
        /// </summary>
        int a;
        /// <summary>
        /// This method is used to swap values of two variables
        /// </summary>
        /// <param name="a">First ref parameter or variable </param>
        /// <param name="b">Second ref parameter or variable</param>
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
            SwapMethods obj = new SwapMethods();
            obj.a = 1;
            int a = 20, b = 10;
            Console.WriteLine("Before swap: a={0} and b={1} ",a,b);
            swap(ref a,ref b);//passing argument by value
            Console.WriteLine("After swap: a={0} and b={1}" ,a,b);
        }
    }
}
