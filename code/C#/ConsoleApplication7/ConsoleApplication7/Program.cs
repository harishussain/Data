using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class A
    {
        public A()
        {
            Console.WriteLine("base class constructor");

        }
    }
    public class B : A
    {
        public B()
        {
            Console.WriteLine("first child of A");
        }
    }
    public class C : B
    {
        public C()
        {
            Console.WriteLine("child of B");
        }

        class Program
        {
            static void Main()
            {
                C ob1 = new C();
                Console.WriteLine(ob1);
                Console.Read();


            }
        }

    }