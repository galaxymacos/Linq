using System;
using System.Collections.Generic;
using System.Linq;
using MyExtensionLibrary;

namespace SortingData
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rand = new Random();
            var randomValues = Enumerable.Range(1, 10).Select(x => rand.Next(11) - 5);
            var enumerable = randomValues as int[] ?? randomValues.ToArray();
            var csvString = new Func<IEnumerable<int>, string>(values =>
            {
                return string.Join(",", values.Select(v => v.ToString()).ToArray());
            });
            
            Console.WriteLine(csvString(enumerable));
            Console.WriteLine(csvString(enumerable.OrderBy(n => n)));
            Console.WriteLine(csvString(enumerable.OrderByDescending(n => n)));            
            
            // Sorting class
            var people = new List<Person>
            {
                new Person{Name = "Liu Yongchen",Age = 22},
                new Person{Name = "Ruan Xun",Age = 21},
                new Person{Name = "Ruan Xun",Age = 20},
                new Person{Name = "He Huixian",Age = 22},
            };
            // Sort elements based on two criterias
            people.OrderByDescending(p => p.Name).ThenBy(p=>p.Age).Print();
            
            // Reverse a string
            string str = "abcdefg";
            Console.WriteLine(new string(str.Reverse().ToArray()));
        }
    }
}