using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Person
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
            if (p == null) return false;
            if (p == this) return true;

            return Object.Equals(this.name, p.name) && Object.Equals(this.age, p.age);
        }

        public override string ToString()
        {
            return $"{name} ({age} y.o.)";
        }
    }
}
