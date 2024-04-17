using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to heothi Program");
            Console.WriteLine("this progam will compute your indicator");
            double weight = 70.0;
            double heigh = 1.7;
            double bmi= weight/(heigh*heigh);
            Console.WriteLine("you bmi based on weigh: {0} and heigh: {1} , bmi {2}", weight, heigh,bmi);
            Console.WriteLine($"you bmi based on weigh: {weight} and heigh: {heigh} , bmi {bmi}");

            Console.WriteLine("Xung quanh anh toàn là nước cơ thể anh đang bị ướt\r\nMênh mông toàn là nước êm ái như chưa từng trước đây\r\nTrăm ngàn con sóng xô anh lao vào trong biển cả vì em làm anh nóng khô\r\nAnh ngâm mình trong làn nước để mặn mòi từ da dẻ");

            Console.WriteLine(@"Xung quanh anh toàn là nước cơ thể anh đang bị ướt
Mênh mông toàn là nước êm ái như chưa từng trước đây
Trăm ngàn con sóng xô anh lao vào trong biển cả vì em làm anh nóng khô
Anh ngâm mình trong làn nước để mặn mòi từ da dẻ

Ta cần tình yêu vì tình yêu làm cho ta trẻ
Anh cũng cần em nhưng không biết em sao
Anh không care lắm và anh quyết đem trao
Cho em hết nắng cho em hết đêm sao
");
            string path = @"D:\FPT";

            Console.ReadLine();
        }
    }
}
