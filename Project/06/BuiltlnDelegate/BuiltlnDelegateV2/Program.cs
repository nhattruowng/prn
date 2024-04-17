namespace BuiltlnDelegateV2
{
    internal class Program
    {
        // viet ham nhan vao 2 con so in ra tich
        delegate void Comp(double a, double b);
        static void Main(string[] args)
        {
            Comp a = (x, y) => Console.WriteLine(x * y);
            a(10, 20);
            Console.WriteLine();
            Action<double,double> b = (d,c) => Console.WriteLine(d * c);
            b(10, 20);
        }


    }
}
