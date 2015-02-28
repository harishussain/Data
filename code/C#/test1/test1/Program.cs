using System;

public abstract class Bank
{
    public abstract void CreateAccount();
    public abstract void DepositAmount();
    public abstract void WithDrawAmount();

    public void CalculateInterest()
    { Console.WriteLine("calculate interest for Bank"); }
    public void SetInterest()
    {
        Console.WriteLine("set interest rate for Bank");
    }
}
class BharatiBank : Bank
{
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
        Console.WriteLine("Withdraw amount from Baharti Bank");
    }
    public void OnlineBanking()
    {
        Console.WriteLine("Online banking for Bharati bank");
    }
}
public class RupeeBank : Bank
{
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
        Console.WriteLine("Withdraw amount from Rupee Bank");
    }
    public void Banking()
    {
        Console.WriteLine("banking system for Rupee bank");
    }
}
class Program
{
    public static void Main()
    {
        BharatiBank obj = new BharatiBank();
        RupeeBank obj2 = new RupeeBank();
        Bank ob = (Bank)obj;
        Bank ob2 = (Bank)obj2;

        obj.CreateAccount();
        obj.DepositAmount();
        obj.WithDrawAmount();

        obj2.CreateAccount();
        obj2.DepositAmount();
        obj2.WithDrawAmount();
        Console.ReadLine();
    }
}
