using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4._6
{
    internal class ByWeightSorter : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Weight.CompareTo(y.Weight); // Sammenlign vægt
        }
    
    }
}
