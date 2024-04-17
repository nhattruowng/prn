using StudentManagerV3.Entities;
using StudentManagerV3.Services;

namespace StudentManagerV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student studenA = new Student() { Id = 1, Name = "TruongA", Gpa = 8.0 };
            Student studenB = new Student() { Id = 2, Name = "TruongB" };
            
            var cabinetA = new CabinetStuden();
            cabinetA.AddStuden(studenA);
            cabinetA.AddStuden(studenB);
           
            cabinetA.PrintStuden();


            Console.WriteLine();
            var lecturesA= new Lectures() { Id=1,Name="TruongC",Yob=1998};
            Lectures lecturesC = new Lectures() { Id = 2, Name = "TruongD", Salary = 99.0 };
            CabinetLectures cabinetLecturesA = new CabinetLectures();
            cabinetLecturesA.AddLectur(lecturesA);
            cabinetLecturesA.AddLectur(lecturesC);

            cabinetLecturesA.PrinLecture();
            Console.WriteLine();





            var Cabinit = new Cabinet<Student>();
            Cabinit.AddStuden(studenA);
            Cabinit.AddStuden(studenB);
            
            Console.WriteLine("List Studen:");
            Cabinit.PrinStudentList();
            Console.WriteLine();

            
            var cabinit2 = new Cabinet<Lectures>();
            cabinit2.AddStuden(lecturesA);
            cabinit2.AddStuden(lecturesC);
            Console.WriteLine("List lecture:");
            cabinit2.PrinStudentList();
        }
    }
}
