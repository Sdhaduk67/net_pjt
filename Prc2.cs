using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_pjt
{
    internal class Prc2
    {
        static void Main(string[] args) 
        {
            Console.Write("Enter Mobile Number: ");
            string number = Console.ReadLine();
            if (number.Length >= 5)
            {
                string visible = number.Substring(0, number.Length - 5);
                string masked = "XXXXX"; 

                Console.WriteLine("Output: " + visible + masked);
            }
            else
            {
                Console.WriteLine("Please enter at least 5 digits.");
            }
        }
    }
}
