using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    enum weekday:int
    { mon,tue,wed,thr,fri,sat,sun}
    class Program
    {
        static void Main()
        {
            weekday w;
            w = weekday.fri;
            Console.WriteLine(w);
            Console.Read();
        }
    }
}
