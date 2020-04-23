using System;

namespace Scramblies
      //testing(Scramblies.Scramble("rkqodlw","world"), true);
      //  testing(Scramblies.Scramble("cedewaraaossoqqyt","codewars"),true);
      //  testing(Scramblies.Scramble("katas","steak"),false);
      //  testing(Scramblies.Scramble("scriptjavx","javascript"),false);
      //  testing(Scramblies.Scramble("scriptingjava","javascript"),true);
      //  testing(Scramblies.Scramble("scriptsjava","javascripts"),true);
      //  testing(Scramblies.Scramble("javscripts","javascript"),false);
      //  testing(Scramblies.Scramble("aabbcamaomsccdd","commas"),true);
      //  testing(Scramblies.Scramble("commas","commas"),true);
      //  testing(Scramblies.Scramble("sammoc","commas"),true);
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "acdf1gdg";
            string str2 = "c";
            bool x=false;
            int n = 0;
            String str3 = str1.ToLower();
            for (int v = 0; v < str1.Length; v++)
            {
                if (!char.IsLetter(str1, v))
                {
                    n = 1;
                }
            }
            if (n != 1)
            {


                if (str3 == str1 || str1.Length < str2.Length)
                {
                    for (int i = 0; i < str2.Length; i++)
                    {
                        for (int z = 0; z < str1.Length; z++)
                        {
                            if (Char.IsLetter(str1, z))
                            {


                                if (str2[i] == str1[z])
                                {

                                    x = true;
                                    str1 = str1.Remove(z, 1);

                                    break;
                                }
                            }
                            x = false;
                        }
                        if (x == false)
                        {
                            break;
                        }

                    }
                }
            }
           
            Console.WriteLine(x);
            Console.ReadLine();

        }
    }
}
