using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ass7
{
   public  abstract class Bank
    { 
       //re definiable abstract methods:
        public abstract void CreateAccount();
        public abstract void DepositAmount();
        public abstract void WithDrawAmount();

       //virtual methods

        public virtual void CalculateInterest()
        {
            Console.WriteLine("calculate interest for Bank");
        }
        
        public virtual void SetInterest()
        {
            Console.WriteLine("set interest rate for Bank");
        }
 
   }
    public class BharatiBank:Bank

    {
        //defining the base class methods here:
            public override void CreateAccount()
            {
                Console.WriteLine("create account in Bharati Bank");
            }
            public override void DepositAmount()
            {
                Console.WriteLine("Deposit amount in Baharti bank");
                
            }
            public override void WithDrawAmount()
            {
                Console.WriteLine("withdraw amount from Baharti Bank");
            }
        //redefining non overridable methods
            public sealed override void CalculateInterest()
            {

                Console.WriteLine("calculate interest fo Bharati Bank");
            }
         
            public sealed override void  SetInterest()
         {
             Console.WriteLine("set interest rate for Baharti Bank");
        }
           
        
    }
   public  class RupeeBank :Bank 
    {
       //defining the base class methods here:

        public override void CreateAccount()
        {
            Console.WriteLine("create account in Rupee Bank");
        }
        public override void DepositAmount()
        {
            Console.WriteLine("Deposit amount in Rupee Bank");

        }
        public override void WithDrawAmount()
        {
            Console.WriteLine("withdraw amount from Rupee Bank");
        }

       //re defining non overridable methods
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("calculate interest for Rupee Bank");
        }
       
        public sealed override void SetInterest()
        {
            Console.WriteLine("set interest rate for Rupee Bank");
       
        }
    }
public class checkBank:Bank{
    public override void WithDrawAmount()
    {
        Console.WriteLine("withdraw amount from check Bank");
    }
    public override void CreateAccount()
    {
        Console.WriteLine("create account in check Bank");
    }
    public override void DepositAmount()
    {
        Console.WriteLine("Deposit amount in check bank");

    }

}
 
    class Program
    {
       public  static void Main()
        {
            RupeeBank ob = new RupeeBank();
            BharatiBank op = new BharatiBank();
            checkBank oc = new checkBank();
            op.CreateAccount();
            op.DepositAmount();
            op.WithDrawAmount();
            op.CalculateInterest();
            op.SetInterest();

            ob.CreateAccount();
            ob.DepositAmount();
            ob.WithDrawAmount();
            ob.CalculateInterest();
            ob.SetInterest();
            oc.WithDrawAmount();
   
         
            Console.ReadLine();
        }
    }
}
