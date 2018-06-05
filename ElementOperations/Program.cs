using System;
using System.Collections.Generic;
using System.Linq;

namespace ElementOperations
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> {1,1, 2, 3};
            Console.WriteLine(numbers.First());
            Console.WriteLine(numbers.First(x=>x>2));    // throw exception if no element satisfied this predicate
            Console.WriteLine(numbers.Last());
            Console.WriteLine(numbers.Last(x=>x>2));
            Console.WriteLine(numbers.FirstOrDefault(x=>x>10));    
            // will not throw exception; instead, return a default value
            Console.WriteLine(numbers.Single(x=>x==1));    // 
            Console.WriteLine(numbers.SingleOrDefault(x=>x>1));
        }
    }
}