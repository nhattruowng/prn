using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV4.Services
{
    internal class Cabinet<T>
    {
        private List<T> _list = new();

        public void AddObj(T obj)
        {
            _list.Add(obj);
        }
        public void PrintObj()
        {
            foreach (T obj in _list) Console.WriteLine(obj);
        }
    }
}
