using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dupless
{
    class Program
    {
        static void RemoveDupLinq(string[] stringArr)
        {
            string[] newstringArr = stringArr.Distinct().ToArray();
            for (int i = 0; i < newstringArr.Length; i++)
            {
                Console.WriteLine(newstringArr[i]);
            }
            Console.ReadLine();
        }

        static void RemoveDupTra(string[] stringArr)
        {
            List<string> stringArrList = new List<string>();
            foreach (string s in stringArr)
            {
                if (!stringArrList.Contains(s))
                {
                    stringArrList.Add(s);
                }

            }
            string[] newstring = stringArrList.ToArray();
            for (int i = 0; i < newstring.Length; i++)
            {
                Console.WriteLine(newstring[i]);
            }
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            string[] str = new string[] { "sun", "mon", "tues", "tues", "sun" };
            RemoveDupLinq(str);
            RemoveDupTra(str);

        }
    }

}