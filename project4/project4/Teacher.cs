﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    internal class Teacher
    {
        public string Name;
        public int Class;
        public char Section;

        public Teacher(string name, int classes, char section)
        {
            Name = name;
            Class = classes;
            Section = section;
        }
    }
}
