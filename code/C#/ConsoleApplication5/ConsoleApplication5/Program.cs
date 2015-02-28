using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Man Obj1 = new Man();
            Obj1.Eat();
            Woman Obj2 = new Woman();
            Obj2.Eat();
            Console.ReadLine();
        }
    }
    class Human
    {
        public void Eat()
        {
            Console.WriteLine("Human Eat");
        }
    }
    class Man : Human { }
    class Woman : Human { }
}


