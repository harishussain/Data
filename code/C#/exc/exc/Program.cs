using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exc
{
    class BoilerException : Exception
    {
      public  BoilerException() : base() { }
      public  BoilerException(string msg) : base(msg) { }
      public  BoilerException(string msg,Exception innerException):base(msg,innerException){}
      protected BoilerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) 
      { }
       public override string ToString()
    {
        return Message;
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
