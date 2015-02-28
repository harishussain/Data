using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PascalCase
{
    public static class Extension
    {
     
      public static string CaseConversion(this string Operate)
        {
            string Newstring = "";
            bool SawUnderScore = false;

           foreach (char c in Operate)
           {
               if (Newstring.Length == 0 && char.IsLetter(c))
                   Newstring +=char.ToLower(c);
               else if (c == '_')
                   SawUnderScore=true;
               else if(SawUnderScore)
               {
                   Newstring= Newstring+'_'+char.ToUpper(c);
                   SawUnderScore = false;
               }
               else Newstring += c;

           }
           return Newstring;
        }

      static void Main()
      {
          string[] argument = new string[] {"Check_it_out","best_in_all"};
          foreach (string s in argument)
          {
              Console.WriteLine(s.ToString());
              Console.WriteLine(s.CaseConversion());
              Console.ReadLine();
          }
      }

    }
}
