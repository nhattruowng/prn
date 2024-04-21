namespace NumberServicesV2
{
    internal class Program
    {
        /// co nhiu data giong list cung cap dich vu su ly truy van data 
        /// vd co mang cac so nguyn 
        /// tui muon cung cap dich vu lay data theo yeu cau.
        /// vd: in ra ds cac so lon hon 0.
        /// in ra ds cac so chan
        /// in ra cac so lon hon 2000 
        /// in ra cac so le la so nguyn to 
        /// ...
        /// 
        /// tiep can: 
        /// 


        /// co nhiu data va tra ve data.
        /// gan giong POD nhung can kiem xoat data nhiu hon.
        static void Main(string[] args)
        {
            List<int> list = Where(x => true);

            list.ForEach(x => Console.Write($"{x} "));

            list = Where(x => x > 30);
            list.ForEach(x => Console.Write($"{x} "));



            Console.WriteLine("Using LinQ");

            List<int>list2= list.Where(x => x % 2 == 0).ToList();
            list2.ForEach(x => Console.Write(x));
        }

        static List<int> Where(Func<int, bool> f)
        {
            List<int> list = new() { 10, 20, 22, 11, 32, 44, 22, 51, 33 };
            List<int> result = new();
            foreach (int x in list)
                if (f(x)) result.Add(x);
            return result;

        }

        /// K can tu lam ham vi list co san code tren giup hieu sau ve Loose Couping, ham da dung da muc dich cua delegate.
    }
}
