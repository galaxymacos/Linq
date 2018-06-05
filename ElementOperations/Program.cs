using System;
using System.Collections.Generic;
using System.Linq;

namespace ElementOperations
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> {1, 2, 3};
            Console.WriteLine(numbers.First());
            Console.WriteLine(numbers.First(x=>x>2));
            Console.WriteLine(numbers.FirstOrDefault(x=>x>10));

//            Console.WriteLine(numbers.Single());
// throw exception if the collection has more or less than one element
            
            Console.WriteLine(new int[]{}.SingleOrDefault());    // will still throw an exception when number of elements is more than 1


            Console.WriteLine("Item at position 1: "+numbers.ElementAt(1));    // since not every collection has indexer
            Console.WriteLine("Item at position 4: "+numbers.ElementAtOrDefault(4));    // so will not throw ArgumentOutOfRangeException
        }
    }
}