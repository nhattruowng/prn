namespace ListAndDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List And Delegate:");
            // co 1 day so hay in ra so theo yeu cau:
            List<int> arr = new List<int>() { 5, 10, 15, 20, 1, 3, 5, 7, 2, 4, 6, 8, 39, 79, 100 };

            // hay in danh sach
            foreach (int i in arr) Console.Write($"{i} ");

            // hay in full danh sach dung delegate
            Console.WriteLine();
            arr.ForEach(x =>
            {
                if (x >= 20) Console.Write($"{x} ");
            });
        }
    }
}
