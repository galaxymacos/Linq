using System;
using System.Collections;

namespace SelectAndSelectMany
{
    public static class EnumerableExtensions
    {
        public static void Print(this IEnumerable enumerable)
        {
            foreach (var element in enumerable)
            {
                Console.Write(element+" ");
            }

            Console.WriteLine();
        }
    }
}