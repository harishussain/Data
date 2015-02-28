using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ass1
{
    interface IA
    {
     void write(int a,int b);
 
    }
    interface IB
    {
      void write();
    }
    class C:IA,IB
    {
       public void write(int a,int b)
        {
           int c=a;
           int d=b;
           
            Console.WriteLine("C writes Well {0} and {1}", c, d);
        }
       public void write()
        {
            Console.WriteLine("C writes Well");

        }
    }
    class Program
    {
        static void Main()
        {
            C obj = new C();
            //obj.write(3, 4);
            //obj.write();
            IA obj1 = (IA)obj;
            IB obj2 = (IB)obj;
            obj1.write(3,4);
            obj2.write();

            Console.ReadLine();
        }
    }
}
