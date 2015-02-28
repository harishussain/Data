using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Ass4
{
    class Account
    {
        Account() { }
        Account(int IntRate)
        {
            this.intRate = IntRate;
            Console.WriteLine("InterestRate:"+intRate);
      
        }
        private int id;
        private string name;
        private int intRate;
        private string password;

        public int account_no
        {
            get;
            set;
        }

        public int ID
        {
            get
            {
             return id;   
            }
            set
            {
                id = value;
            }
              
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            { 
                name = value; 
            }

        }

        public int IntRate
        {

            get 
            {

               return intRate;
            }
        }

        public string Password
        {
  
            set
            {
                password = value;
            }

        }


        class Program
        {

            static void Main(string[] args)
            {
   
            
                Account ob = new Account(1500);
                ob.ID = 001;
                ob.Name = "Haris Hussain";
                ob.account_no = 11001;
                ob.Password = "topsecret";

                Console.Write("UserID: {0} Name: {1} AccountNo: {2}", ob.ID, ob.Name,ob.account_no);
                Console.WriteLine();
                Console.Read();



            }
        }
    }
}