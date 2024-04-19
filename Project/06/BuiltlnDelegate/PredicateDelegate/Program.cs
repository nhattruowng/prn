namespace PredicateDelegate
{
    internal class Program
    {
        delegate bool check(int x);

        // viet ham nhan vao con so nguyen tra ve lon hon 10 hay k 
        // viet ham nhan vao con so nguyen tra ve no chia het 2 hay k 
        static void Main(string[] args)
        {


            check A = Check;
            Console.WriteLine($"FunA (11):{A(11)}");
            Console.WriteLine($"FunA (6):{A(6)}");
            check B = x =>
            {
                if (x > 10) return x % 5 == 0;
                return false;
            };
            Console.WriteLine($"Fun B(20):{B(20)}");
            Console.WriteLine($"FunB (6):{B(6)}");

            Predicate<int> C = x =>
            {
                if (x > 10) return x % 5 == 0;
                return false;
            };

            Console.WriteLine($"Fun 3(100):{C(100)}");
            Console.WriteLine($"FunC (6):{C(6)}");
        }

        static bool Check(int x)
        {
            if (x > 10) return x % 5 == 0;
            return false;
        }

    }
}
