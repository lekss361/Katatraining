using System;

namespace Who_likes_it
{
    class Program
    {
        static void Main(string[] args)
        {
            string ret="";
           string[] name=new string[] { "Max", "John", "Mark" };
            if (name.Length<2)
            {
                switch (name.Length)
                {
                    case 0:
                        ret = "no one likes this";
                        break;
                    case 1:
                        ret = name[0] + "and " + name[1] + " like this";
                        break;
                    case 2:
                        ret = name[0]+", "+name[1]+" and "+name[2]+" like this";
                        break;                    
                }

            }
            else
            {
                ret=name[0]+", "+name[1]+",and "+(name.Length-2)+" others like this";
            }
            return (ret);
        }
    }
}
