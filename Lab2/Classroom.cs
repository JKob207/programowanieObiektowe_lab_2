using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Classroom
    {
        private string name { get; set; }
        private Person[] persons { get; set; }

        private Student _student;
        private Teacher _teacher;

        Classroom(string n, Person[] p)
        {
            name = n;
            persons = p;
        }

        public override string ToString()
        {
            return $"Classroom: {name}";
        }
    }
}
