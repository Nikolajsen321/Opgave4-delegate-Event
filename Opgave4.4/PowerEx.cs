using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4._4
{
    internal static class PowerEx
    {
        public static int PowerExten(this int n, int p)
        {
            if(p == 0)
            {
                return 1;
            }
            else
            {
                return n * n.PowerExten(p-1);
            }
        }
    }
}
