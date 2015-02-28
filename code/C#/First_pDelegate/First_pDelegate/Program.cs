using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_pDelegate
{
    delegate string StrMod(string s);
    class DelegateTest
    {
        public string RemoveSpace(string arg)
        {
            Console.WriteLine("Removing space");
            string temp = "";
            for (int i = 0; i < arg.Length; i++)
            {
                if (arg[i] != ' ')
                {
                    temp = temp+arg[i];
                }
               
            }
            return temp;
        }
        public string ReplaceHyphen(string arg)
        {
            Console.WriteLine("replaceing space with hyphen");
            return arg.Replace(' ', '_');
        }
        public  string Reverse(string arg)
        {
            Console.WriteLine("Replacing the data");
            string temp="";
            for (int i = arg.Length-1; i>=0; i--)
            {
                temp=temp+arg[i];
            }
            return temp;
        }
        static void Main(string[] args)
        {
            DelegateTest obj = new DelegateTest();
            StrMod Strob = obj.RemoveSpace;
            string str;
            str = Strob("Its a delegate program");
            Console.WriteLine("removal result is: "+str);
            Strob = obj.ReplaceHyphen;
            str = Strob("looking for some logic");
            Console.WriteLine("exchane result is: "+str);
            Strob = obj.Reverse;
            str = Strob("Robert Lafore");
            Console.WriteLine("Reverse order is: "+ str);
            Console.ReadLine();

        }
    }
}
