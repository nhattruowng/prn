using StudentManagerV4.Entities;
using System.Xml.Linq;

namespace StudentManagerV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithIntergerList();

            Console.WriteLine();
            PlayWithStudentList();
        }

        static void PlayWithIntergerList()
        {
            List<int> arr = new();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            List<int> arr2 = new() { 3, 4, 5, 5, 6 };

            foreach (int x in arr) Console.Write(x + " ");

            Console.WriteLine();
            foreach (var x in arr2) Console.Write(x + " ");

            Console.WriteLine();
            for (int x = 0; x < arr.Count; x++) Console.Write(arr[x] + " ");
        }


        static void PlayWithStudentList()
        {
            List<Student> arr = new();
            Student student = new Student() { Id = 01, Name = "Truong", Gpa = 8.0 };


            arr.Add(student);

            arr.Add(new Student()
            {
                Id = 01,
                Name = "TruongB",
                Gpa = 9.0,
                Yob = 21
            });

            Console.WriteLine("List Studen:");
            foreach (var x in arr) Console.WriteLine(x);

        }
    }
}
