using System;

namespace kata_Multiples_of_3_or_5
{
//    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

//Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

//Note: If the number is a multiple of both 3 and 5, only count it once.
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int z = 0;
            int c = 0;
            int result=0;
            int[] multiplicity3=new int[x];
            int[] multiplicity5=new int[x];
            for (int i = 0; i < x; i++)
            {
                if (i%3==0)
                {
                    multiplicity3[z] = i;
                    z++;
                }
                else if (i%5==0)
                {
                    multiplicity5[c] = i;
                    c++;
                }          

            }
            for (int i = 0; i < x; i++)
            {
                result += multiplicity3[i] + multiplicity5[i];
            }
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
