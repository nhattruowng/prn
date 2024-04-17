using Bmi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = BmiCalculator.GetBMI(70,1.7);

            Console.WriteLine(bmi);
            Console.ReadLine();
        }
    }
}
