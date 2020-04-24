using System;

namespace Count_the_smiley_faces_
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }));
            
        }
        public static int CountSmileys(string[] smileys)
        {
            int c = 0;
            for (int i = 0; i < smileys.Length; i++)
            {
                char[] smile = smileys[i].ToCharArray();
                
                    switch (smile.Length) 
                    {
                        case 2:
                            if (smile[0]==':'||smile[0]==';')
                            {
                                if (smile[1]== ')'||smile[1]== 'D')
                                {
                                c++;
                                }
                            }
                        break;
                    case 3:
                        if (smile[0] == ':' || smile[0] == ';')
                        {
                            if (smile[1] == '-' || smile[1] == '~')
                            {
                                if (smile[2] == ')' || smile[2] == 'D')
                                {
                                    c++;
                                }
                            }
                        }
                        break;
                    default:
                        break;
                    }            
            }            
            return c;
        }
    }
}
