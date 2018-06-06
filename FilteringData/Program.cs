using System.Linq;
using MyExtensionLibrary;

namespace FilteringData
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);
            var enumerable = numbers as int[] ?? numbers.ToArray();
            
            // Filter by a predicate
            var evenNumber = enumerable.Where(n => n % 2 == 0);
            evenNumber.Print();
            var oddSquares = enumerable.Select(x => x * x).Where(y => y % 2 == 1);
            oddSquares.Print();

            // Filter by type
            object[] values = {1, 2.5, 3, 4.56f};
            values.OfType<byte>().Print();
        }
    }
}