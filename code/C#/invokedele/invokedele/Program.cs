using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace invokedele
{
    delegate void mydele(int ID,string Name);
     class myclass
    {
        //public  void invokedele(mydele obj)
        //{
        //    obj(119,"huges Norton");
        //}
        public void display(int id, string name)
    {
        Console.WriteLine("Name = {0} \n ID={1}",name,id);
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
             myclass obj = new myclass();
            mydele deleobj = obj.display;
             //obj.invokedele(deleobj);
            deleobj.Invoke(13, "haris");
            Console.ReadLine();


        }
    }
}

