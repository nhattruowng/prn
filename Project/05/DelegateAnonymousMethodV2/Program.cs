namespace DelegateAnonymousMethodV2
{
    internal class Program
    {
        delegate double A(double a, double b);
        static void Main(string[] args)
        {
            A a = delegate (double a, double b) 
            {
                return Math.Pow(a, b);
            };        
            Console.WriteLine(a(3, 4));
        }
        /// viet ham le nhan vao 2 con so thuc va tra ve dien tich HCN
        /// viet ham khong ten nhan vao 2 con so a vs b tra ve a^b
        /// 

        static double CompuleRectangArea(double a, double b) => a * b;

       

    }
}
