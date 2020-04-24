using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_occurrences_of_an_element_if_it_occurs_more_than_n_times
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DeleteNth(new int[] { 20, 37, 21 }, 1));
            Console.ReadLine();
        }
        public static int[] DeleteNth(int[] arr, int x)
        {
            string[] ars = new string[arr.Length];
            ars = arr.ToString();
            int v = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int c = 1; c < arr.Length; c++)
                {
                    if (arr[i]==arr[x])
                    {
                        v++;
                        if (v>=x)
                        {
                            
                        }
                    }
                }
            }
            return c;
        }
    }
}
