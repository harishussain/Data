using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agecal
{
    class Program
    {
        public static void calage(DateTime birthdate)
        {
            DateTime currdate = DateTime.Now;
            Console.WriteLine(currdate.Date.ToString());
            Console.WriteLine(birthdate.Date.ToString());
            int age = currdate.Year - birthdate.Year;

                if(birthdate.Month > currdate.Month)
                {
                    age--;
                }
                Console.WriteLine("ur are of {0} years",age);
                Console.ReadLine();

        }
         
      static void Main(string[] args)
        {
            calage(DateTime.Parse("12/7/1992"));
        }
    }
}
