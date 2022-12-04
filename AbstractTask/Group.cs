using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask
{
    internal class Group : Student
    {
        public int No;
        public byte Limit = 18;

        public Group(string name, string surname, string group, int no, byte limit) : base(name, surname, group)
        {
            No = no;
            Limit = limit;
        }
        public void AddStudent(string telebe)
        {
        Student[] students = new Student[18];

            for (int i = 0; i < students.Length; i++)
            {
                if ( students.Length<=18)
                {
                    Console.WriteLine();
                }
            }
        }
        public override string Telebe()
        {
            throw new NotImplementedException();
        }

    }
}
