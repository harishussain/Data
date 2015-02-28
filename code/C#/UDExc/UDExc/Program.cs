using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UDExc
{
    class BoilerException : Exception
    {
        public BoilerException() : base() { }
        public BoilerException(string message) : base(message) { }
        public BoilerException(string message, Exception inner) : base(message, inner) { }
        protected BoilerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString()
        {
            return this.ToString();
        }
    }
    class Boiler
    {
        private int pressure;
        public int Pressure
        {
            set
            {
                pressure = value;

            }
            get
            {
                return pressure;
            }

        }
        public void increase()
        {
            Pressure += 100;
            if (Pressure > 900)
            {

                throw new BoilerException("pressure is too high");
            }
        }
        public void decrease()
        {
            Pressure -= 100;
            if (Pressure < 800)
            {
                throw new BoilerException("pressure is too low");
            }

        }

    }
    class CatchExc
    {
        static void Main(string[] args)
        {
            Boiler excObj = new Boiler();
            excObj.Pressure = 700;



            try
            {

                excObj.increase();
                excObj.increase();
                excObj.increase();
            }


            catch (BoilerException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                Console.WriteLine("leaving try");
            }
            Console.WriteLine(excObj.Pressure.ToString());

            try
            {
                excObj.decrease();
                excObj.decrease();
                excObj.decrease();
                excObj.decrease();
            }
            catch (BoilerException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                Console.WriteLine("leaving try");
            }
            
            
            Console.WriteLine(excObj.Pressure.ToString());
        
           Console.ReadLine();
        }
    }
}
