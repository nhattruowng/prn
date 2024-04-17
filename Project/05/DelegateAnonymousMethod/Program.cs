namespace DelegateAnonymousMethod
{
    internal class Program
    {
        // viet ham in ra cau thong bao hello C# 
        // goi ham nhung k dc goi trc tiep



        //
        delegate void Prin();
        static void Main(string[] args)
        {
            Prin a = PrintHello;
            a();
            // viet ham in ra 2 cau chao khac 
            //" du ai di nguoc ve suoi
            // nho ngay gio to 10/3"
            // ma k duoc dung ham le
            a = delegate ()
            {
                Console.WriteLine("du ai di nguoc ve suoi");
                Console.WriteLine("nho ngay gio to 10/3");
            };
            a();

            // viet ham in ra tong cac so tu 1 > 100 k dc sd ham le.

            a = delegate ()
            {
                int sum = 0;
                for (int i = 1; i <= 100; i++) sum += i;
                Console.WriteLine($"tong = {sum}");
            };
            a();
        }

        static void Tho()
        {
            Console.WriteLine("du ai di nguoc ve suoi");
            Console.WriteLine("nho ngay gio to 10/3");
        }
        static void PrintHello()
        {
            Console.WriteLine("Hello C#");
            Console.WriteLine("Hello delegate:");
        }
        
    }
}
