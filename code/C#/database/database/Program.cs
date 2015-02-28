using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace database
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindDataSet())
            {
                foreach (var i in db.Customers)
                

                    Console.WriteLine(db.Customers.i);


                }
                Console.ReadLine();
}
        }
    }
}
