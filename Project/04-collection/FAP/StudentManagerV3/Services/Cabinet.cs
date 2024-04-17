using StudentManagerV3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3.Services
{
    internal class Cabinet<T>
    {
        private T[] _arr = new T[30];
        private int _count = 0;


        public void AddStuden(T s)
        {
            _arr[_count] = s;
            _count++;
        }

        public void PrinStudentList()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine($"{_arr[i]}");
            }
        }
    }
}
