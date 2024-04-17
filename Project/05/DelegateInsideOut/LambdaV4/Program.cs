namespace LambdaV4
{
    internal class Program
    {
        delegate int A(int x);
        static void Main(string[] args)
        {   
            // anonimuos
            A a = delegate (int x)
            {
                return x * x;
            };
            Console.WriteLine($"{a(3)}");
            // lambda
            a = x => x * x;
            Console.WriteLine($"{a(4)}");


           
        }
        /// viet ham nhan 1 tra ve binh phuong
        /// anonimuos 
        /// lambda
       
    }
}
