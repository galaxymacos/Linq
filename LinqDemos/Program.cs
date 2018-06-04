using System;
using System.Collections;
using System.Linq;

namespace LinqDemos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new ArrayList {1, 2, 3};
            Console.WriteLine(list.Cast<int>().Average());

            var numbers = Enumerable.Range(1, 10);
            var enumerable = numbers as int[] ?? numbers.ToArray();
            var arr = enumerable.ToArray();
            var arrList = enumerable.ToList();
            var dict = enumerable.ToDictionary(i => (double) i / 10, i => i % 2 == 0);
            foreach (var keyValuePair in dict) Console.WriteLine(keyValuePair.Key + " " + keyValuePair.Value);

            var arr2 = new[] {1, 2, 3};
            var arre = arr2.AsEnumerable();
        }
    }
}