using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    internal class Subject
    {
        public string Name;
        public int SubjectCode;
        public string Teacher;

        public Subject(string name, int subjectCode, string teacher)
        {
            Name = name;
            SubjectCode = subjectCode;
            Teacher = teacher;
        }
    }
}
