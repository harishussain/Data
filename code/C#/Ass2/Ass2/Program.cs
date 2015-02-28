using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ass2
{
    class User
    { 
        public string Name;
        protected string Address;
        internal string Designation;

        public void machenical()
        {
            Console.WriteLine("the machanical method");
        }
        protected void civil()
        {
            Console.WriteLine("the civil method");
        }
        internal void software()
        {
            Console.WriteLine("the software method");
        }
        private void Electrical()
        {
            Console.WriteLine("the electrical method");
        }
    }

    class Library
    {
        static void Main(string[] args)
        {
            User obj = new User();
            obj.machenical();
           // obj.civil(); Inaccessable due to its protection level
            obj.software();
            obj.Name = "Haris";
            //obj.Address = "phaseIV";Inaccessable due to its protection level
            obj.Designation = "Manager";
            Console.WriteLine("{0}\n{1}",obj.Name,obj.Designation);
            Console.ReadLine();


        }
    }
}
