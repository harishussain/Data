using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ass5
{
    class Account
    {
        public int num;
        public string name;
        public double bal;
        public byte ac_code;
        public Account()
        { }
        public  Account(int a)
        { num = a;
        Console.WriteLine(num);
        }
       public Account(string b)
        { name = b;
        Console.WriteLine(name);
        }
       public Account(byte d)
       {
           ac_code = d;
           Console.WriteLine(ac_code);
           Console.ReadLine();

       }
       public  Account(double c)
       { bal = c;
       Console.WriteLine(bal);
       }

       public virtual void privillage()
       {
           Console.WriteLine("Administration has supreme privillage on Account");
       }
       public  virtual  void getit()
       { Console.WriteLine("jst do it"); }

    }
  sealed class Admin // non inheritable class
    {
        public void privillage()
        {
            Console.WriteLine("Administration has sealed privillage");
        }
    }
  class User: Account
  {
        public int group_no;
        public string mail_Id;
        public double balance;
        public User()
         { }
        public User(int group_no)
            : base(509)
        {
            this.group_no = group_no;
            Console.WriteLine(group_no);
        }
       public User(string mail_Id)
           : base("MailTo")
       { Console.WriteLine(mail_Id);  
       }
       public User(byte number)
           : base(509)
       {
           Console.WriteLine(number);
       }
       public User(double balance) : base(42.5)
        {
        Console.WriteLine(balance);
        Console.ReadLine();
        }
       public sealed override void getit()//non overridable method
       {
           Console.WriteLine("its user's sealed privillage account ");
       }
       public override void privillage()
       { Console.WriteLine("its user's overridable privillage account"); }
       }
    class Program
    {
        static void Main()
        {
     
            User obj = new User(296);
            User obj1= new User("post");
            User obj2 = new User(4);
            User obj3 = new User(32.3);
            User ob = new User();
             ob.privillage();
             ob.getit();
            Console.ReadLine();
           

         
        }
    }

}

