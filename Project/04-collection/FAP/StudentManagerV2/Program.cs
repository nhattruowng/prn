using StudentManagerV2.Services;

namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet Se = new Cabinet();
            Cabinet Gd = new Cabinet();
            Se.AddStudent(new Entities.Student() { Id = 01, Name= " truowng" }) ;
            Gd.AddStudent(new Entities.Student() { Id = 02, Name = "TruongGd" });


            Se.PrintStudenList();
            Gd.PrintStudenList();


        }
    }
}
