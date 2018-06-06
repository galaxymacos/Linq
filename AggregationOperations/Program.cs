using System;
using System.Collections.Generic;
using System.Linq;
using MyExtensionLibrary;
using System.Drawing;

namespace AggregationOperations
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);
            var enumerable = numbers as int[] ?? numbers.ToArray();
            Console.WriteLine($"We have {enumerable.Count()} elements");

            enumerable.Print();

            var sum = enumerable.Aggregate((p, x) => p + x);    // p stands for partial sum
            Console.WriteLine(sum);

            var product = enumerable.Aggregate(1,(p, x) => p * x);
            Console.WriteLine(product);
            
            // do them the easier way
            Console.WriteLine(enumerable.Sum());
            Console.WriteLine(enumerable.Average());

            var words = new[] {"one", "two", "three"};
            Console.WriteLine(words.Aggregate("Hello",(p,x)=>p+" "+x));    // "Hello" is the seed value
            
            // Rectangle.Union(r1,r2)
            Console.WriteLine($"Poly 2 [3,4,5] = {Poly(2,new[]{3,4,5})}");
            
        }
        
        public static int Poly(int x, IEnumerable<int> coeffs)
        {
            var items = coeffs.ToList();
            int order = items.Count-1;
            return items.Aggregate(0,(p, y) => p + y*(int) Math.Pow(x, order--));
        }
        
        
    }
}