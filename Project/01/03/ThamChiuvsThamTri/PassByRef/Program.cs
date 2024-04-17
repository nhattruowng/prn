namespace PassByRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine($"value = {x}");
            PassByRef(ref x);
            Console.WriteLine($"value after = {x}");
        }

        // ref

        static void PassByRef(ref int value)
        {
            value = 111;
        }
    }
}
