using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace method_conversion
{
    delegate void calc(ref int a, int b, int c);
    class del
    {
        public static void add(ref int x,int y,int z)
        {
            double result = x + y + z;
            Console.WriteLine(result);
            //return result;
        }
        public static void multiply(ref int x,int y,int z)
        {
            double result = x * y * z;
            Console.WriteLine(result);
            //return result;
        }
        public static void subtract(ref int x,int y,int z)
        {
            double result = x - y - z;
            Console.WriteLine(result);
            // return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           //double result;
            int a = 20;
            int b = 10;
            int c = 5;
            calc deleob;
            calc Add = del.add;
            calc Multiply = del.multiply;
            calc Subtract = del.subtract;
            deleob = Add;
            deleob += Multiply;
             deleob(ref a,b,c);
            deleob -=Add;
            deleob -= Multiply;
            deleob += Subtract;
            deleob(ref a,  b, c);
            //calc deleob1 = del.subtract;
            //calc deleob2 = del.multiply;
            //deleob(20, 10, 5);
            ////.WriteLine(result);
            //deleob1(20, 10, 5);
            ////Console.WriteLine(result);
            //deleob2(20, 10, 5);
            ////Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
