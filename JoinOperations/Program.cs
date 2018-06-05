using System;
using System.Linq;
using System.Xml.Schema;

namespace JoinOperations
{
    public class Person
    {
        public string Name, Email;

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

    public class Record
    {
        public string Mail, SkypeId;

        public Record(string mail, string skypeId)
        {
            Mail = mail;
            SkypeId = skypeId;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var people = new Person[]
            {
                new Person("Jane", "jane@foo.com"),
                new Person("John", "john@foo.com"),
                new Person("Chris", string.Empty)
            };

            var records = new Record[]
            {
                new Record("jane@foo.com", "JaneAtFoo"),
                new Record("jane@foo.com", "JaneAtHome"),
                new Record("john@foo.com", "John1980")
            };

            var query = people.Join(records,
                x => x.Email,
                y => y.Mail,
                (person, record) => new {Name = person.Name, SkypeId = record.SkypeId});
            foreach (var i in query)
            {
                Console.WriteLine($"{i.Name} has the skype ID {i.SkypeId}");
            }
            
            // GroupJoin NOTE hard
            var query2 = people.GroupJoin(records,
                x => x.Email,
                y => y.Mail,
                (person, recs) => new {Name = person.Name, SkypeIds = recs.Select(r => r.SkypeId)});
            foreach (var i in query2)
            {
                Console.WriteLine($"{i.Name} has the skype id: ");
                foreach (string skypeId in i.SkypeIds)
                {
                    Console.WriteLine($"\t\t\t{skypeId}");
                }
            }
        }
    }
}