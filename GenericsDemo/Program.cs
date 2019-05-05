using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        static void Main(string[] args)
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5 };
            var list2 = new List<int> { 2, 4, 6, 8, 10 };
            var set1 = new HashSet<int> { 3, 6, 9, 12, 15 };
            /*var*/ int[] array1 = new int[5] { 4, 8, 12, 16, 20 };   // new[] { .. }; or new int[] { .. }
            //int[] intArray = new int[2];
            //intArray[0] = 1;
            //intArray[1] = 2;
        }
    }
}
