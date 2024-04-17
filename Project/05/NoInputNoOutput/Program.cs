namespace NoInputNoOutput
{
    internal class Program
    {
        delegate void NoInputNoOutput();
        static void Main(string[] args)
        {
            Console.WriteLine("funtion 1:");
            SayHello();
            Console.WriteLine("funtion 2:");
            SayHelloNvh();
            Console.WriteLine("funtion 3:");
            PrintInterger();

            Console.WriteLine("PlayWithDelagate: ");
            NoInputNoOutput a = SayHello;
            a();
            a = SayHelloNvh;
            a();

            a.Invoke();

            Console.WriteLine("----");
            a += PrintInterger;
            a += SayHello;
            a();

        }

        /// 3 ham
        /// 1. in ra 2 cau chao HelloC#
        /// ````````````        hello delegate.
        /// in ra so tu nhien 1 - 100;
        /// in ra cau chao hello nvj sv
        

        static void SayHello()
        {
            Console.WriteLine("Hello C#");
            Console.WriteLine("hello delegate");
        }
        static void SayHelloNvh() => Console.WriteLine("Hello nvh sv");
        static void PrintInterger()
        {
            for(int i = 1;i <= 100; i++) Console.Write($"{i} ");
            Console.WriteLine();
        }
        
    }
}
