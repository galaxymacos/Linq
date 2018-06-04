using System;
using System.Linq;
using MyExtensionLibrary;

namespace SelectAndSelectMany
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 4);
            var squares = numbers.Select(i => i * i); // map
            squares.Print();

            const string sentence = "This is a nice sentence";
            // Get the length of each word as an array
            var wordLengths = sentence.Split(' ').Select(word => word.Length);
            wordLengths.Print();

            // Get the length of each word as an array with words themselves
            // Using anonymous type
            var wordsWithLength = sentence
                .Split(' ').Select(w => new {Word = w, Size = w.Length});
            wordsWithLength.Print();

            // Create 10 random numbers
            var rand = new Random();
            var randomNumbers = Enumerable.Range(1, 10).Select(i => rand.Next(10));
            randomNumbers.Print();

            // flatten
            var sequences = new[] {"red,green,blue", "orange", "white,pink"};
            sequences.SelectMany(str => str.Split(',')).Print();

            // pairing two arrays
            string[] objects = {"house", "car", "bicycle"};
            string[] colors = {"red", "green", "gray"};
            var pairs = colors.SelectMany(_ => objects,
                (c, o) => new {Color = c, Obj = o});
            pairs.Print();
        }
    }
}