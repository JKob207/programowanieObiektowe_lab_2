using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student: Person
    {
        protected string group { get; set; }
        protected List<Task> tasks;
        private Task _task1;

        public Student(string n, int a, string g) : base(n,a)
        {
            name = n;
            age = a;
            group = g;
        }

        public Student(string n, int a, string g, List<Task> t) : base(n, a)
        {
            name = n;
            age = a;
            group = g;
            tasks = t;
        }

        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            _task1 = new Task(taskName, taskStatus);
            tasks.Add(_task1);
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            tasks[index].status = taskStatus;
        }

        public void RemoveTask(int index)
        {
            tasks.RemoveAt(index);
        }

        public void RenderTaks(string prefix = "\t")
        {
            Console.WriteLine("Tasks: ");
            foreach (Task t in tasks)
            {
                Console.WriteLine($"{prefix} {t}");
            }
        }

        public override string ToString()
        {
            return $"Student: {name} ({age} y.o.)";
        }

        public bool Equals(Student s)
        {
            if (s == null) return false;
            if (s == this) return true;

            return Object.Equals(this.name, s.name) && Object.Equals(this.age, s.age);
        }

        private bool SequenceEqual(List<Student> a, List<Student> b)
        {
            return a.SequenceEqual(b);
        }
    }
}
