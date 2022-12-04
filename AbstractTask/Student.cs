using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask
{
    internal abstract class Student
    {
        public string Name;
        public string Surname;
        private string Group;

        protected Student(string name, string surname, string group)
        {
            Name = name;
            Surname = surname;
            Group = group;
        }

        public abstract string Telebe();
    }
}
