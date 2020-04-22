using System;

namespace Create_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            string number ="("+numbers[0]+numbers[1]+numbers[2]+") "+numbers[3]+numbers[4]+numbers[5]+"-"+numbers[6]+numbers[7]+numbers[8]+numbers[9];
            return(number);
        }
    }
}
