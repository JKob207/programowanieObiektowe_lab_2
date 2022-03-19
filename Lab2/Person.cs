using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Person
    {
        protected string name { get; set; }
        protected int age { get; set; }

        public Person (string n, int a)
        {
            name = n;
            age = a;
        }

        public bool Equals(Person p)
        {
            return this.name.Equals(p.name) && this.age.Equals(p.name);
        }

        public override string ToString()
        {
            return $"{name} ({age} y.o.)";
        }
    }
}
