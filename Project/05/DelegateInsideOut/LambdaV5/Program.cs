namespace LambdaV5
{
    internal class Program
    {
        // nhan 2 tham so => tra ve
        delegate double TowIn(double a, double b);
        static void Main(string[] args)
        {
            TowIn a = delegate (double a, double b)
            {
                return a * b;
            };

            Console.WriteLine(a(5, 10));


            // lambda 
            a = (x, y) => x * y;
            Console.WriteLine(a(10,20));
        }

        /// nhan 2 so thuc => tra ve
        /// tinh dien tich chu nhat
       
    }
}
