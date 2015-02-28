using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
    class demo
    {
        public double purchasefig { get; set; }
        public string userName { get; set; }
        public int userID { get; set; }
        public demo(double purchase, string name, int ID)
        {
            purchase = purchasefig;
            name = userName;
            ID = userID;

        }

     public string GetContactInfo() {return "ContactInfo";}
    public string GetTransactionHistory() {return "History";}
    }
        class Program
        {
            static void Main()
            {
                demo obj = new demo(3654.25, "haris", 061);
                Console.Write(obj);
                obj.purchasefig += 499.99;
                //obj.userID = 016;
                Console.WriteLine();
                Console.Read();

            }

        }

*/
        // This class is mutable. Its data can be modified from 
        // outside the class. 
        class Customer
        {
            // Auto-Impl Properties for trivial get and set 
            public double TotalPurchases { get; set; }
            public string Name { get; set; }
            public int CustomerID { get; set; }

            // Constructor 
            public Customer(double purchases, string name, int ID)
            {
                TotalPurchases = purchases;
                Name = name;
                CustomerID = ID;
            }
            // Methods 
            public string GetContactInfo() { return "ContactInfo"; }
            public string GetTransactionHistory() { return "History"; }

            // .. Additional methods, events, etc.
        }

        class Program
        {
            static void Main()
            {
                // Intialize a new object.
                Customer cust1 = new Customer(4987.63, "Northwind", 90108);
                Console.Write(cust1);
                //Modify a property
                cust1.TotalPurchases += 499.99;
                Console.Write(cust1);
                Console.WriteLine();
                    Console.Read();
            }
        }