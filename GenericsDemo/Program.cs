using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsDemo
{
    class Program
    {
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        public static int CountOdd(IEnumerable<int> collection)
        {
            int numOdd = 0;
            foreach (var element in collection)
            {
                if (IsOdd(element))
                    numOdd++;
            }

            return numOdd;
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

            Console.WriteLine(string.Format("Number of odds in {0}: {1}", nameof(list1), list1.CountOdd() /*CountOdd(list1)*/));
            Console.WriteLine(string.Format("Number of odds in {0}: {1}", nameof(list2), CountOdd(list2)));
            Console.WriteLine(string.Format("Number of odds in {0}: {1}", nameof(set1), CountOdd(set1)));
            Console.WriteLine(string.Format("Number of odds in {0}: {1}", nameof(array1), array1.Where(e => e % 2 != 0).Count() /*CountOdd(array1)*/));

            // var ec = new EnumerableCompositor<int>(new IEnumerable<int>[] { list1, list2, set1, array1 });
            var ec = new EnumerableCompositor<int> { list1, list2, set1, array1 }; // COLLECTION INITIALIZATION LIST
            int numOdd = 0;
            foreach(var value in ec)
            {
                if(IsOdd(value))
                {
                    numOdd++;
                }
            }

            Console.ReadLine();
        }
    }
}
