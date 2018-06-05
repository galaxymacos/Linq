using System;
using System.Linq;

namespace QuantifierOperations
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5};
            Console.WriteLine("Are all numbers > 0? "+numbers.All(n=>n>0));
            Console.WriteLine("Are all numbers odd? "+numbers.All(n=>n%2==1));
            Console.WriteLine("Any number < 2? "+numbers.Any(n=>n<2));
            
            // Check if a collection is empty
            int[] intArray = {};
            Console.WriteLine("Does array have any elements? "+intArray.Any());
            
            // Contains check whether an IEnumerable contain a specific value
            Console.WriteLine("Does the array contain five? "+numbers.Contains(5));
        }
    }
}