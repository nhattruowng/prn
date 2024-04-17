namespace InputNoOutPut
{
    internal class Program
    {
        delegate void Pow(int x);
        static void Main(string[] args)
        {
            Console.WriteLine("Fun 1");
            PowerBy2(2);
            Console.WriteLine("Fun 2");
            PowerBy10(2);

            Console.WriteLine("delagete: ");
            Pow a = PowerBy10;
            a += PowerBy2;

            a(2);

        }

        // 2 ham
        /// nhan 1 so nguyen in ra binh phuong 
        /// nhan ham 1 so nguyn in ra ^10
        

        static void PowerBy2(int x) => Console.WriteLine($"{x}^2={x * x}");
        static void PowerBy10(int x) => Console.WriteLine($"{x}^10 = {Math.Pow(x, 10)}");
    }
}
