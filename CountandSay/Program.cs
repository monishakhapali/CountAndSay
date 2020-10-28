using System;
using System.Linq;

namespace CountandSay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int n = 4;
            string r = "1";

            while (n != 0)
            {
               
                char prev = char.MinValue;
                foreach (char c in r)
                {
                    
                    int freq = r.Count(f => f == c);
                    if(r=="1")
                    {
                        r = freq.ToString() + r;
                    }
                    else
                    {
                        if(c!= prev)
                        {
                            r = freq.ToString() + c;
                            prev = c;
                           
                        }
                    }

                }
                n--;
            }
        }
    }
}
