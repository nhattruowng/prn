using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithIntergers();
        }


        // pascal case notetion vs camel case notatiol 
        static void PlayWithIntergers()
        {
            // java; in, long, float, double, char,boolear => kieu nguyen thuy
            //c# :in, long, float, double, char,boolear => value type data type 

            //=> ca 2 ton 1 vung ram luu value

            // <=> object type or reference type.=> 2 vung ram 
            int yob = 2003;/// 4byte 
            Console.WriteLine(yob);
            long vietlott = 300_000_000_000;
            Console.WriteLine(vietlott);
            int? dayOfWeek=null; // map truoc tiep voi cot tren db cho phep null - nullable
            //dayOfWeek = 0;
            Console.WriteLine(dayOfWeek);



            Console.ReadLine();
        }

    }
}
