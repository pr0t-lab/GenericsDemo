using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public static class IEnumerableExtensions
    {
        public static int CountOdd(this IEnumerable<int> @this)
        {
            int numOdd = 0;

            foreach(var element in @this)
            {
                if (element % 2 != 0)
                    numOdd++;
            }

            return numOdd;
        }
    }
}
