using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new ArrayList {1, 2, 3};
            Console.WriteLine(list.Cast<int>().Average());

            IEnumerable<int> numbers = Enumerable.Range(1, 10);
            int[] enumerable = numbers as int[] ?? numbers.ToArray();
            int[] arr = enumerable.ToArray();
            List<int> arrList = enumerable.ToList();
            Dictionary<double, bool> dict = enumerable.ToDictionary(i => (double) i / 10, i => i % 2 == 0);
            foreach (KeyValuePair<double,bool> keyValuePair in dict)
            {
                Console.WriteLine(keyValuePair.Key+" "+keyValuePair.Value);
            }

            var arr2 = new[] {1, 2, 3};
            IEnumerable<int> arre = arr2.AsEnumerable();
        }
    }
}