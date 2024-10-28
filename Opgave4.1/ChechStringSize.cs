using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4._1
{
    internal  static class ChechStringSize
    {
        public static bool ChechForStringSizeIsOrUnder5(this string element)
        {
            return element.Length <= 5;
        }
    }
}
