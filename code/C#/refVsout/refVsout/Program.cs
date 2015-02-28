using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Program
    {
        public static void change(out int a)
        {
            a = 6;
            Console.WriteLine(a);
            Console.ReadLine();
        }
        //public static void change(out int a)
        //{
        //    a = 7;
        //}

    public static void Main()
        {
            //int a = 7;
            //Console.WriteLine(a);
            //change(ref a);
            //Console.WriteLine(a);
            //Console.ReadLine();

            int a;
           // Console.WriteLine(a);
            change(out a);
            Console.WriteLine(a);
            Console.ReadLine();
          }
        

 }


