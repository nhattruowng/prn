using StudentManagerV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Services
{
    internal class Cabinet
    {
        private Student[] _arr = new Student[30];
        //public Cabinet(int size) => _arr = new Student[size];
        private int _count = 0;

        // in toan bo danh sach sv
        public void PrintStudenList()
        {
            Console.WriteLine($"Count = {_count}");

            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        // co cac hanh dong CRUD - CREATE | RETRIEVE/READ| UPDATE| DELETE.

        public void AddStudent(Student s)
        {
            _arr[_count] = s;
            _count++;
        }
        //TODO: mang day ?
        // kiem tra mang full _count = _arr.lenght .


    }
    
}
