namespace ThamChiuvsThamTri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6868;
            PassByValue(n);
            Console.WriteLine($"after calling the method x ={n}");
            //cach 1: (out)
            PassByOut(out n);
            Console.WriteLine($"after calling the method out x ={n}");

            // cach 2: (out) sd lien.
            PassByOut(out int y);// khai bao gop != khai bao local =>
            Console.WriteLine($"y after calling passOut = {y}");


        }

        // truyen tham tri.
        // gia tri o dau do duoc truyen qua tham so chi lay gia tri(copy).
        // gia tri valua != voi tham so vao nen k anh huong den gia tri tham so dau vao.
        static void PassByValue(int value) 
        {
            Console.WriteLine($"In methor , at first x= {value}");
            value = 6789;
            Console.WriteLine($"in methor, laster x={value}");
        }

        //truyen tham chiu => dia chi.
        // java : obj <=> c# obj & value type.
        // C# dung keywork OUT,Ref tren tham so ham.
        // sua thay doi ca tham so goc.
        static void PassByOut(out int value)
        {
            value = 6789;
        }
    }
}
