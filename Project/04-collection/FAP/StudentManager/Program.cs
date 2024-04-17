using StudentManager.Entities;
using System.Threading.Channels;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // PlayWithPrimitiveArray();
            PlayWithStudenList();
        }

        static void PlayWithStudenList()
        {
            Students students1 = new Students() { Id=01,Name="Truong",Yob=2003,Gpa=8.8};
            Students students2 = new Students() { Id = 02, Name = "Truong2" };
            
            Students[] arrr = new Students[] {students1,students2 };

            Console.WriteLine(students1);
            arrr[0].Gpa = 1;
            Console.WriteLine(students1);

            arrr[2] = new Students() {Id= 03, Name="Truong3" };

            foreach (Students item in arrr)
                Console.WriteLine(item);

        }
        static void PlayWithPrimitiveArray() // luu 10 con so nguyen 
        {
            // cach 1: khai bao 10 bien le.
            // 1 value kem 1 bien.
            // 10 bien la 10 con so nguyen.
            int a = 5;
            int b = 10;
            int c = 15;
            int d = 20;
            int e = 30;
            int f = 31;
            int g = 32;
            int h = 64;
            int k = 128;
            int l = 256;

            // cach 2: khai bao nhieu bien si.
            // 2.1 dung mang.
            int[] arr1 = new int[10];
            int[] arr2 = new int[3] { 5, 10, 15 };
            int[] arr3 = { 1, 2, 3, 4 };
            // 2.2 dung collection
            // foreach v1.
            foreach (var item in arr3)  Console.Write(item);
            Console.WriteLine();
            // foreach v2.
            foreach (var x in arr3) Console.Write(x);

                       
        }
    }
}
