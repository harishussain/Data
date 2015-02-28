using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buisness
{
    class Program
    {
        static void Main()
        {
            decimal price,dis_price;
            int discount;
            Console.WriteLine("Enter the price");
            price=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter discount in percent");
            discount = Convert.ToInt32(Console.ReadLine());
            dis_price = price - (discount * price / 100);
            Console.WriteLine("price was: " + price);
            Console.WriteLine("after discount: " + dis_price);

            Console.Read();
        }
    }
}
