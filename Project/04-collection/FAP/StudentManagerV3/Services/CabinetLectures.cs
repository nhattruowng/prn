using StudentManagerV3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3.Services
{
    internal class CabinetLectures
    {
        Lectures[] _cabinetLecture = new Lectures[30];
        private int _count = 0;

        public void AddLectur(Lectures l)
        {
            _cabinetLecture[_count++] = l;

            if (_count > 30)
            {
                Console.WriteLine("full arr");
            }
        }

        public void PrinLecture()
        {
            Console.WriteLine("Lecture List");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine($"Leture{i}: {_cabinetLecture[i]}");
            }
        }
    }
}
