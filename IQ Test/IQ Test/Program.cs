﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9"));
            Console.ReadLine();

        }
        public static int Test(string numbers)
        {
                
            int c=0;
            string [] number=numbers.Split(new char[] { ' ' });
            string maschet = "";
            string masnechet = "";
            for (int i = 0; i < number.Length; i++)
            {
                if (Convert.ToInt32(number[i])%2==0)
                {
                    maschet += i;
                }
                else
                {
                    masnechet += i;
                }
                
            }
            if (maschet.Length < masnechet.Length)
            {
                c =Convert.ToInt32(maschet);
            }
            else
            {
                c = Convert.ToInt32(masnechet);
            }
            return c+1;
        }
    }
}
