using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18_1
{
    class Person
    {
        string name;
        string country;
        int age;

        public Person(string name, string country, int age)
        {
            this.name = name;
            this.country = country;
            this.age = age;
        }

        public int Age { get => age; set => age = value; }
        public string Country { get => country; set => country = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return name + " " + country + " " + age;
        }
    }
}
