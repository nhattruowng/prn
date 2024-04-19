namespace NumberServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintAll(x => Console.WriteLine(x));

            Console.WriteLine();
            PrintAll(y =>
            {
                if (y % 5 == 0)
                    Console.WriteLine(y);
            });

            Console.WriteLine();
            PrintAll(x =>
            {
                if (x > 20 && x < 40) Console.WriteLine(x);
            });
        }

        static void PrintAll(Action<int> f)
        {
            //f(10);
            //f(20);
            //f(31);

            for (int i = 0; i < 100; i++) f(i);
        }

    }
}
