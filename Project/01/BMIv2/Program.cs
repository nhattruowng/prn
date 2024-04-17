using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BMIv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = GetBMI(70, 1.7);
            Console.WriteLine($"your bmi: {bmi}");
            Console.ReadLine();

        }

        static double GetBMI(double wight,double heigh)
        {
            //return wight/(heigh*heigh);
            return wight / Math.Pow(heigh,2);
        }

    }
}
