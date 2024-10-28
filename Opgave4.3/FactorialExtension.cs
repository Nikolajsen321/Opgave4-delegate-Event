using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4._3
{
    internal static class FactorialExtension
    {
        public static int FactorialEx(this int n) 
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * (n-1).FactorialEx();
            }
        }
    }
}
