using System;

namespace Disemvowel_Trolls
{
//    Trolls are attacking your comment section!
//A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
//Your task is to write a function that takes a string and return a new string with all vowels removed.
//For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
//Note: for this kata y isn't considered a vowel.
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Read";
            string vowel = "aeiouyAEIOUY";
            char[] vowels = vowel.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                for (int z = 0; z < vowels.Length; z++)
                {
                    if (input[i]==vowels[z])
                    {
                        input = input.Remove(i, 1);
                        i--;
                    }
                }
            }
            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
