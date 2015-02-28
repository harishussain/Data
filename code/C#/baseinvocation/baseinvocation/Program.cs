using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace baseinvocation
{
    class Program
    {
        
        static bool power2(int num)
        {
            return (num != 0 && (num & (num - 1)) == 0);
           
   

        }
        
        static void Main(string[] args)
        {
           bool Flag = false;
            Flag = power2(8);
            Console.WriteLine(Flag.ToString());
            string check = "ham aham ham  ham ham aa dk kkk dkd ";
            int wordcount=0;
           int charcount=0;
            foreach (char c in check)
            {
                if (c == 'a')
                charcount++;
                 
            }
            foreach(Match m in Regex.Matches(check,"ham"))
            {
                wordcount++;
            }
            Console.WriteLine("word count : "+wordcount);
            Console.WriteLine("char count :" +charcount);
        
            Console.ReadLine();

        }
    
    }
}
