using System;

namespace Find_the_odd_int
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 20, 1, -1,20,-1 };
            int v = 0;
            int b,n=0;
            for (int i = 0; i <numbers.Length; i++)
            {
                
                

                for (int x = 0; x <numbers.Length; x++)
                    {
                   
                        if (numbers[i]==numbers[x])
                        {
                            v++;
                        n=x;
                        }
                }
                if (v%2!=0)
                {
                    b=numbers[n];
                }
                v = 0;
                

            }
            Console.ReadLine();



        }
    }
}
