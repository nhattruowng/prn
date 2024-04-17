namespace PassByOutUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            math(out int SumO ,out int SumE,out int CountP,out int Sum);
            Console.WriteLine($"sochan = {SumO}");
            Console.WriteLine($"tongsole = {SumE}");
            Console.WriteLine($"dem so nguyen to = {CountP}");
            Console.WriteLine($"Tong = {Sum}");
        }

        static void PassByIn(in int x)
        {
            //x = 100;
        }
        // Viet ham tinh toan tren day so 1-100;
        // 1-100 co bao nhieu so chan, tong so le, den xem so nguyen to,tong cua all.

        // tra ve gia tri k in ra 

        static void math(out int SumO, out int SumE, out int CountP, out int Sum)
        {
            SumO = 0;
            SumE = 0;
            CountP = 0;
            Sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                if(i % 2 == 0)
                    SumO++;
                else
                    SumE += i;
                Sum += i;
                if(i > 1)
                {
                    for(int j =2; j< i; j++)
                    {

                    }
                }
            }
        }
    }
}
