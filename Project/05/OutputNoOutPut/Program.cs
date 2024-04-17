namespace OutputNoOutPut
{
    internal class Program
    {
        delegate int OutputNoOutPut();
        static void Main(string[] args)
        {
            Console.WriteLine("Funtion 1");
            Console.WriteLine($"{Return()}");
            Console.WriteLine("Funtion 2");
            Console.WriteLine($"{Sum()}");
            Console.WriteLine("Funtion 3");
            Console.WriteLine($"{Count()}");


            Console.WriteLine("DELEGATE: ");
            OutputNoOutPut a = Return;
            a += Count;
            a += Sum;
            Console.WriteLine($"{a()}");
            Console.WriteLine($"{a()}");
           

        }

        /// viet ham
        /// 1. tra ve con so 6789
        /// 2. tr ve tong cac so 1-100
        /// 3. tra ve dem xem co bao nhieu so chia het 5 ( 1-100) 
        /// 
        static int Return() => 6789;

        static int Sum()
        {
            int sum = 0;
            for (int i = 1;i <= 100;i++) sum += i;
            return sum;
        }
        static int Count()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if(i % 5 ==0) count++;
            }
            return count;
        }

    }
}
