using System;
using System.Linq;
using MyExtensionLibrary;

namespace PartitioningData
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new[] {3, 3, 2, 2, 1, 1, 2, 2, 3, 3};
            
            // Skip the first two elements, and take the next 6 elements
            numbers.Skip(2).Take(6).Print();
            
            // Skip elements using a predicate
            numbers.SkipWhile(i => i == 3).Print();
            numbers.TakeWhile(i => i > 1).Print();
        }
    }
}