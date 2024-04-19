namespace DelegateInUse_PassByDelage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            In("NhatTruong");

            Action<string> In1 = x => Console.WriteLine(x);
            In1("NhatTruong1");

            In2(() =>
            {
                Console.WriteLine("Hello");
            });



            Action A = () => Console.WriteLine("hello");
            In2(A);


            Action check = () =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (CheckPrime(i)) Console.WriteLine($"{i} {CheckPrime(i)}");
                }
            };

            In2(check);

            /// viet ham POD de in ra cac so tu 1000 -2000
            /// 
            In2(() =>
            {
                for (int i = 100; i <= 200; i++)
                    Console.Write($"{i} ");
            });

        }


        // viet ham in ra chuoi bth 
        // viet ham in ra chuoi bth dung Action 
        // viet ham in theo yeu cau

        static bool CheckPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            for (int i = 2; i < Math.Sqrt(n); i++)

                if (n % i == 0) return false;

            return true;
        }


        static void In2(Action f) => f();

        static void In(string x) => Console.WriteLine(x); // chi nhan ket qua r in k tinh toan duoc.


        /// viet ham POD de in ra cac so tu 1000 -2000
        /// 
    }
}
