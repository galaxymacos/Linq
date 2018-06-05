using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperations
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string word1 = "helloooo";
            string word2 = "help";

            IEnumerable<char> uniqueChars = word1.Distinct();    // NOTE find distinct characters (present only once) in a string
            string strMadeOfUniqueChars = new string(uniqueChars.ToArray());
            foreach (char uniqueChar in strMadeOfUniqueChars)
            {
                Console.Write(uniqueChar+" ");
            }
            Console.WriteLine();
            
            IEnumerable<char> lettersInBoth = word1.Intersect(word2);    // NOTE find characters presented in both strings
            foreach (char c in lettersInBoth)
            {
                Console.Write(c+" ");
            }

            Console.WriteLine();

            var letterInBoth = word1.Union(word2);    // NOTE find characters presented in either of the string
            foreach (char c in letterInBoth)
            {
                Console.Write(c+" ");
            }

            Console.WriteLine();

            var letterOnlyInWord1 = word1.Except(word2);    // NOTE find characters that only in first string but not in the second string
            foreach (char c in letterOnlyInWord1)
            {
                Console.Write(c+" ");
            }

            Console.WriteLine();
        }
    }
}