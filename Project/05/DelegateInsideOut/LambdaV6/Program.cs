namespace LambdaV6
{
    internal class Program
    {
        /// viet ham nhan vao so nguyen ktr chia /2 => tra ve T/F
        delegate bool Check(int x);
        static void Main(string[] args)
        {
            // ktr bang delegate.
            Check a = delegate (int x)
            {  
                return x % 2 == 0;
            };

            Console.WriteLine(a(2));
            Console.WriteLine(a(3));

            // ktr bang lambda. => kiem tra chan le
            a = x => x % 2 == 0;

            Console.WriteLine(a(4));
            Console.WriteLine(a(5));
        }
    }
}
