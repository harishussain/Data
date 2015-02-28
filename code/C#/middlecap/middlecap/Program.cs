using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace middlecap
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                string str = Console.ReadLine();
                int middle = str.Length / 2;
                char ch1 = char.ToUpper(str[0]);
                char ch2 = char.ToUpper(str[middle]);
                char[] charArray = str.ToCharArray();
                charArray[0] = ch1;
                charArray[middle] = ch2;
                Console.WriteLine(charArray);
                
            }
            Console.ReadLine();
        }
    }
}
