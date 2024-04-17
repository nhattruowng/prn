namespace Lambda
{
    internal class Program
    {
        delegate void NoInNoOut();
        static void Main(string[] args)
        {
            NoInNoOut a = delegate ()
            {
                Console.WriteLine("du ai...");
                Console.WriteLine("nho ngay");
            };
            a();
            // lambda 

            a = ()=>{
                Console.WriteLine("du ai...");
                Console.WriteLine("nho ngay");
            };
            a();
        }
        /// viet ham in ra 2 cau tho 
        /// " du ai ....
        /// nho ngay"
        /// khong dc sd ham le
        /// 
    }
}
