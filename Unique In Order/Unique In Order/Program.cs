using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_In_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "AAAABBBCCDAABBB";

            for (int i = 1; i < letters.Length; i++)
            {
                if (letters[i-1]==letters[i])
                {
                    letters = letters.Remove(i, 1);
                    i--;
                }
            }
        }
    }
}
