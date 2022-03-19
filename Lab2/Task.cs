using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected
    }

    class Task
    {
        private string name;
        private TaskStatus status;

        public Task(string n, TaskStatus s)
        {
            name = n;
            status = s;
        }
        public override string ToString()
        {
            return $"{name} [{status}]";
        }
        public bool Equals(Task t)
        {
            if (t == null) return false;
            if (t == this) return true;

            return Object.Equals(this.name, t.name) && Object.Equals(this.status, t.status);
        }
    }
}
