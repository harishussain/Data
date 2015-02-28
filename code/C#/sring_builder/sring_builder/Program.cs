using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sring_builder
{
    class Program
    {
        static void Main()
        {
            StringBuilder mystring = new StringBuilder();
            string[] days = new string[] { "sunday", "monday", "tuesday" };
                                              
            bool flag = true;
            mystring.AppendFormat("which of the three value is {0}", flag);
            mystring.AppendLine();
            for (int i = 0; i <=days.GetUpperBound(0); i++)
            {
                mystring.AppendFormat("   {0}. {1}", i, days[i]);
                mystring.AppendLine();
            }

            mystring.AppendLine();
            Console.WriteLine(mystring.ToString());
            Console.Read();
            
            
        }
            
    }
}
