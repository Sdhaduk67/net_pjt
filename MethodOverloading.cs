using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_pjt
{
    internal class MethodOverloading
    {
        void Sum(int x,int y)
        {
            x = 10;
            y = 20;
        }
        void Sum(int x,float y)
        {
            x = 30;
            y = 302;
        }
        static void Main()
        {

        }
    }
}
