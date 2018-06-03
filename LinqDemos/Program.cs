using System;

namespace LinqDemos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var xun = new Person("xun"," ","ruan");
            foreach (var x in xun.Names)
            {
                Console.WriteLine(x);
            }
        }
    }
}