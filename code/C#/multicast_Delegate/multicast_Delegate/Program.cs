using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace multicast_Delegate
{
    delegate void StrMod(ref string arg);
   
    class DelegateTest
    {
        static void RemoveSpace(ref string arg)
        {
            string temp = "";
           Console.WriteLine("Removing spaces");
           for (int i=0; i < arg.Length;i++ )
           {
               if (arg[i] != ' ')
               {
                   temp += arg[i];
                   arg = temp;
               }
           }
        }
        static void ReplaceSpace(ref string arg)
        {
            Console.WriteLine("Replacing spaces with hyphen");

            arg= arg.Replace(' ', '_');
        }

        static void Reverse(ref string arg)
        {
            string temp = "";
            Console.WriteLine("Reversing string.");
            for (int i = arg.Length - 1; i >= 0; i--)
                temp += arg[i];
            arg = temp;
                    
        }
   

        static void Main(string[] args)
        {
            StrMod Strop;
            StrMod replacespace=ReplaceSpace;
            StrMod reverse = Reverse;
            StrMod removespace =RemoveSpace;
           
            Strop = replacespace;
            Strop += reverse;
            string str = "its all about logic";
            Strop(ref str);
            //str = "Now work for this";
            ////Strop -= replacespace;
            ////Strop += removespace;

            ////Strop(ref str);  
            Console.WriteLine("value is : " +str);
            Console.ReadLine();
 
        }
    }
}
