using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace bits
{
    delegate void MyEventHandler();
    class MyEvent
    {
        public event MyEventHandler SomeEvent;
        public void OnSomeEvent()
        {
            if (SomeEvent!=null)
                SomeEvent();
        }

    }
    class X
    {
        public void XHandler()
        {
            Console.WriteLine("X event occured");
        }
    }
    class Y
    {
        public void YHandler()
        {
            Console.WriteLine("Y event occured");
        }

    }
    class EventDemo
    {
        public static void Handler()
        {
            Console.WriteLine("Event occured!");
        }
        public static void Main(string[] Args)
        {
            MyEvent obj = new MyEvent();
            X xob = new X();
            Y yob = new Y();
            obj.SomeEvent += Handler;
            obj.SomeEvent += xob.XHandler;
            obj.SomeEvent += yob.YHandler;
            obj.OnSomeEvent();
            Console.WriteLine();
            obj.SomeEvent -= xob.XHandler;
            obj.OnSomeEvent();
            Console.ReadLine();

        }

    }
}