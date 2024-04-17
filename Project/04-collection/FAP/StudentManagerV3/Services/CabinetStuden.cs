using StudentManagerV3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3.Services
{
    internal class CabinetStuden 
    {
        private Student[] _arr = new Student[5];
        private int _count = 0;

        public void AddStuden(Student x)
        {
            _arr[_count] = x;
            _count++;
            if( _count == 5 )
            {
                Console.WriteLine("full arr");
            }
        }

        public void PrintStuden()
        {
            Console.WriteLine("List Studen:");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine($"Studen {i}: {_arr[i]}");
            }
        }
    }
}
