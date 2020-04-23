using System;
using System.Linq;

namespace Sort_the_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[] { 5, 3, 2, 8, 1, 4 };
            string num = "";
            int c = 0;
            if (array.Length >= 1)
            {


                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        num += array[i];
                        array[i] = 0;
                    }
                }
                char[] num1 = num.ToCharArray();
                if (array.Length >= 1)
                {


                    char temp;
                    for (int i = 0; i < num1.Length - 1; i++)
                    {
                        for (int j = i + 1; j < num1.Length; j++)
                        {
                            if (num1[i] > num1[j])
                            {
                                temp = num1[i];
                                num1[i] = num1[j];
                                num1[j] = temp;
                            }
                        }
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0)
                    {
                        array[i] = num1[c] - '0';
                        c++;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            
            
        }
    }
}
