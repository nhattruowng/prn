using System.Threading.Channels;

namespace LambdaV2
{
    internal class Program
    {

        delegate void Pow2(int x);
        static void Main(string[] args)
        {
            Pow(2); // goi ham truyen thong.

            /// su dung delegate
            Pow2 a = Pow;
            a(3);


            /// su dung anonimuos funtion.
            a = delegate (int x)  
            {
                Console.WriteLine(Math.Pow(x, 2));
            };
            a(4);


            // bieu thuc lambda
            a = (int x) => Console.WriteLine(Math.Pow(x, 2));

            a(5);

            //- datatype tham so 
            a = (x) => Console.WriteLine(Math.Pow(x, 2));
            a(6);

            // - bo () tren lambda 
            a = x => Console.WriteLine(Math.Pow(x, 2));
            a(7);
           

        }
        /// viet ham nhan vao 1 con so, in ra binh phuong con so do.
        /// viet ham le
        /// viet delegate
        /// viet anonimuos
        /// lamda
         static void Pow(int x) => Console.WriteLine(Math.Pow(x, 2));

    }
}
