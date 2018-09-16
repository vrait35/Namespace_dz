using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Information
    {
        public static string FullName(Person person)
        {
            return person.FirstName +" "+ person.Name + " " + person.LastName;
        }
    }
    public class ConstantPi
    {
        private const double Pi = 3.14;
        public double PI { get { return Pi; } }
        private const string Name = "Исаак Ньютон";
        public string NAME { get { return Name; } }
    }
}
