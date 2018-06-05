using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityOperators
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var arr1 = new[] {1, 2, 3};
            var arr2 = new[] {1, 2, 3};
            Console.WriteLine(arr1 == arr2);
            Console.WriteLine(arr1.Equals(arr2));
            Console.WriteLine(arr1.SequenceEqual(arr2));    // compare the content of two IEnumerable

            var list1 = new List<int> {1, 2, 3};
            Console.WriteLine(arr1.SequenceEqual(list1));    // We can compare an array with a list
        }
    }
}