using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class A
    {
        public A()
        {
            Console.WriteLine("base class");
        }

        public A(string num)
        {
            int i = 5;
            Console.WriteLine("i=" + i);

        }
    }
       
        class outer
        {
            public static void Main()
        {
                A ob=new A();
                Console.WriteLine(ob);
       
}
        }
    }