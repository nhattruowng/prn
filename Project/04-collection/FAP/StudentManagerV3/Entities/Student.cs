﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string ToString() => $"{Id} {Name} {Yob} {Gpa}";
       
    }
}
