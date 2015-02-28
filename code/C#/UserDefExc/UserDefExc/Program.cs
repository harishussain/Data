using System;

public class exceptionBoilerException : Exception
{
    public exceptionBoilerException()
        : base()
    { }
    public exceptionBoilerException(string message)
        : base(message)
    { }
    public exceptionBoilerException(string message, Exception innerException)
        : base(message, innerException)
    { }

    // This constructor is needed for serialization.
    protected exceptionBoilerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    { }
    public override string ToString()
    {
        return Message;
    }
}

class Boiler
{   private double pressure;

    public double Pressure
    {    set { pressure = value; }
    }
    public void Increase()
    {	  pressure=pressure+100;
            if (pressure > 2000)
            {
                throw new exceptionBoilerException("Pressure is too high\n");
            }
    }
    public void decrease()
    {    pressure = pressure-100;
        if (pressure < 500)
        {
           throw new exceptionBoilerException("Pressure is too low\n");
   
        }
    }
}
class DemoBoiler
{
    static void Main()
    {   Boiler ob = new Boiler();
        Boiler ob1 = new Boiler();
        try
        {   ob.Pressure = 1600;
            ob.Increase();
            ob.Increase();
            ob.Increase();
            ob.Increase();
            ob.Increase();
        }
        catch (exceptionBoilerException exc)
        {
            Console.WriteLine(exc);
        }
       try
        {
        ob1.Pressure = 700;
        ob1.decrease();
        ob1.decrease();
        ob1.decrease();
        }
       catch (exceptionBoilerException exc)
       {  Console.WriteLine(exc);
       }
          Console.ReadLine();
       
    }
}


