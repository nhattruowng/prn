namespace BuiltlnDelegate
{
    internal class Program
    {
        delegate void NoInputNoOutput();
        static void Main(string[] args)
        {
            NoInputNoOutput a = () => Console.WriteLine("hello");
            a();
            a = SayHello;
            a();
            Action b = () => Console.WriteLine("hello");
            b();
            b = SayHello;
            b();


            //// viet ham in 1 - 100 sur dungj delegate cua microsoft.

            Action d = () =>
            {
                for (int i = 1; i <= 100; i++) Console.Write($"{i} ");
            };
            d();
           
        }

        /// 

        static void SayHello()
        {
            Console.WriteLine("Du ai...");
            Console.WriteLine(".....10/3");
        }
    }
}
