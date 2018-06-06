using System.Collections.Generic;
using System.Linq;
using MyExtensionLibrary;

namespace ConcatenationOperators
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var integralTypes = new[] {typeof(int), typeof(short)};
            var fpTypes = new[] {typeof(float), typeof(double)};   // concat in positive order
            integralTypes.Concat(fpTypes).Print();    // concat in reverse order
            integralTypes.Concat(fpTypes).Prepend(typeof(bool)).Print();
        }
    }

    static class ExtensionMethods
    {
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> values, T value)
        {
            yield return value;
            foreach (var item in values)
            {
                yield return item;
            }
        }
    }
}