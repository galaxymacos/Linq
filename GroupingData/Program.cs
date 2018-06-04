using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupingData
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
            var people = new List<Person>
            {
                new Person{Name = "Adam",Age = 20},
                new Person{Name = "Adam",Age = 36},
                new Person{Name = "Boris",Age = 18},
                new Person{Name = "Claire",Age = 36},
                new Person{Name = "Adam",Age = 20},
                new Person{Name = "Jack",Age = 20},
            };

            var byNames = people.GroupBy(p => p.Name);
            var byAges = people.GroupBy(p => p.Age<30);    // separate people into two groups 
            
            var byAgeNames = people.GroupBy(p=>p.Age,p=>p.Name);    // the second parameter indicates that p.Name should be the value to separate different objects (Default is the Person object itself)
            foreach (IGrouping<int, string> grouping in byAgeNames)
            {
                Console.WriteLine($"{grouping.Key}");
                foreach (string s in grouping)
                {
                    Console.Write(s+" ");
                }

                Console.WriteLine();
            }
        }
    }
}