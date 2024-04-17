using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    /// <summary>
    /// Class nay dung de cung cap cac ham tinh toan chi so bmi cua moi ca nhan.
    /// </summary>
    public class BmiCalculator
    {
        //ta thiet ke class nhu class tien ich cung cap dich vu


        /// <summary>
        ///     HAM NAY TINH CHI SO BMI DUA TREN CHIU CAO CAN NANG CUA 1 NGUOI
        /// </summary>
        /// <param name="weigh">CAN NANG(KG)</param>
        /// <param name="heigh">CHIU CAO(M)</param>
        /// <returns></returns>
        public static double GetBMI(double weigh,double heigh) =>   weigh / Math.Pow(heigh, 2);
        
        
        //public static double GetBMI(double weigh, double heigh)
        //{
        //    return weigh / Math.Pow(heigh, 2);
        //}


    }
}
