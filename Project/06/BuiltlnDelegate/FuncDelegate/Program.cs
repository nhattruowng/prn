namespace FuncDelegate
{

   // viet ham ta ve 1 con so co dinh
   // Concrete methor - ham le
   // anonimus methor
   // delegate co san



   // viet ham dun Func tra ve int dung lambad
    internal class Program
    {
        delegate int Return1();
        static void Main(string[] args)
        {
            Console.WriteLine("truyen thong:");
            Console.WriteLine($"{Return()}");
            Console.WriteLine("delegate Truyen thong:");
            Return1 a = Return;
            Console.WriteLine($"{a()}");
            Return1 b = () => 3979;
            Console.WriteLine($"{b()}");


            Console.WriteLine("su dung delegate Microsoft:");
            Func<int> A = () => 3979;
            Console.WriteLine($"{A()}");
            Func<int> B = Return;
            Console.WriteLine($"{B()}");
            Console.WriteLine();



            //// 2
            ///
            Func<int> Fun1 = () => 1234;
            Console.WriteLine($"Fun2:{Fun1()}");


            // viet ham dung Func tra ve 1 con double nhan vao 2 double
            // 
            Func<double, double, double> Fun2 = (a, b) => Math.Pow(a, b);
            Console.WriteLine($"Fun3: {Fun2(2,3)}");

            /// nhan vao 1 con so va tra ve so do co chia he 2 hay k 
            /// nhan 1 so ktr so nguyen to
            /// 
            Console.WriteLine();
            Func<int, bool> Fun3 = x => x % 2 == 0;  // expression
            Console.WriteLine($"Check 10:{Fun3(10)}");
            Console.WriteLine($"Check 11:{Fun3(11)}");

            Func<int, bool> Fun4 = x =>
            {
                if (x < 2) return false;
                if (x == 2) return true;
                for (int i = 2; i <= Math.Sqrt(x); i++)
                {
                    if (x % i == 0) return false;
                }
                return true;
            };
            Console.WriteLine($"Check Prime 5: {Fun4(5)}");



        }


        static int Return() => 3979;
        
    }
}
