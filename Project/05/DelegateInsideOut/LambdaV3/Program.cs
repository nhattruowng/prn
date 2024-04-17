namespace LambdaV3
{
    internal class Program
    {
        delegate void Compute(double a, double b);
        static void Main(string[] args)
        {
            // truyen thong
            ComputeRectArea(5, 10);
            // delegate
            Compute a = ComputeRectArea;
            a(10, 15);
            // anonimuos funtion
            a = delegate (double a, double b)
            {
                Console.WriteLine(a * b);
            };
            a(20, 30);
            // lambda
            a = (a,b) => Console.WriteLine(a * b);
            a(30, 40);
        }

        /// viet ham nhan vao 2 con so thuc sau do in ra tich cua chung
        /// 
        /// ham le 
        /// delegate
        /// anonimuos
        /// lambda

        static void ComputeRectArea(double a, double b) => Console.WriteLine(a * b);
        
    }
}
