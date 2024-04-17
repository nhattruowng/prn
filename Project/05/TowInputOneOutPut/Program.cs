namespace TowInputOneOutPut
{
    internal class Program
    {
        delegate double Compute(double a, double b);
        static void Main(string[] args)
        {
            Console.WriteLine("Funtion 1");
            Console.WriteLine($"{ComputeRectangleArea(5.1,10.0)}");
            Console.WriteLine("Funtion 2");
            Console.WriteLine($"{ComputeTriangleAres(7.1,4.3)}");


            Console.WriteLine("Delegate: ");
            Compute a = ComputeRectangleArea;
            Console.WriteLine($"{a(5.1,10.5)}");
            a = ComputeTriangleAres;
            Console.WriteLine($"{a(5.1, 10.5)}");

        }

        /// viet ham nhan vao 2 so thuc tra ve con so thuc
        /// 1. tinh dien tich hinh chu nhat
        /// 2. tinh dien tich tam giac (day* cao)/2
        /// 
        static double ComputeRectangleArea(double a, double b) => a * b;
        static double ComputeTriangleAres(double a, double b) => a * b /2;
        
    }
}
