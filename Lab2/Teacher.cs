using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Teacher : Person
    {
        public Teacher(string n, int a) : base(n,a)
        {
            name = n;
            age = a;
        }
        public override string ToString()
        {
            return $"Teacher: {name} ({age} y.o.)";
        }
    }
}
