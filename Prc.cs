using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_pjt
{
    internal class Prc
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter a number: ");
            string num = Console.ReadLine();

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '0') Console.Write("Zero ");
                else if (num[i] == '1') Console.Write("One ");
                else if (num[i] == '2') Console.Write("Two ");
                else if (num[i] == '3') Console.Write("Three ");
                else if (num[i] == '4') Console.Write("Four ");
                else if (num[i] == '5') Console.Write("Five ");
                else if (num[i] == '6') Console.Write("Six ");
                else if (num[i] == '7') Console.Write("Seven ");
                else if (num[i] == '8') Console.Write("Eight ");
                else if (num[i] == '9') Console.Write("Nine ");
                else Console.Write("Invalid ");
            }
            Console.WriteLine();
        }
    }
}
