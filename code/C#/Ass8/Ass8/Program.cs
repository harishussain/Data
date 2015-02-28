using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ass8
{
    class Boiler
    {
        private double pressure;
        public double Pressure
        {
            set;
            get;
        }


        public void increase()
        {
            Pessure+=100;

            Console.WriteLine(Pressure);
            if (Pressure > 2000)
                throw new Tc();
        }
        public void decrease()
        {
            Pressure -= 100;
            Console.WriteLine(Pressure);
            if (Pressure < 500)
                throw new CustomExceptionHandler();

        }


    }
    class CustomExceptionHandler
    {
        CustomExceptionHandler Tc = new CustomExceptionHandler { Pressure = 4000 };
    }
   class program {
        static void Main(string[] args)
        {
      

        }
    }
}
