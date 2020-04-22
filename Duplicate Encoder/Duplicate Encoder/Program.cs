using System;
using System.Globalization;

namespace Duplicate_Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Success";
            word=word.ToLower();
            
            char[] masword = word.ToCharArray();
            char[] words = word.ToCharArray();
            for (int i = 0; i < masword.Length; i++)
            {
                char c = words[i];
                for (int z = 0; z < masword.Length; z++)
                {
                    if (i != z)
                    {


                        char x = words[z];
                        if (x == c)
                        {
                            masword[i] = ')';
                            break;
                        }
                        else
                        {
                            masword[i] = '(';
                        }
                    }
                }                
            }
            word = new string(masword);
            
        }
    }
}
