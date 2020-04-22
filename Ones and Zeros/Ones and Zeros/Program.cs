using System;

namespace Ones_and_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] BinaryArray= new int[] {0,0,0,0};
            double result=0;
            double[] koef = new double[] { 3.0, 2.0, 1.0, 0.0 };
            for (int i = 0; i < BinaryArray.Length; i++)
            {
                double x = Convert.ToDouble(BinaryArray[i]);
                 result += Math.Pow(2.0, koef[i])*x;
            }
            return result;
        }
    }
}
