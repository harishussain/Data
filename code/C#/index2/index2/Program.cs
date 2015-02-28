using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace index2
{
    class index2
    {

        string[] days = { "Mon", "tues", "wed", "thur", "fri", "sat", "sun" };

        private int GetDay(string testDay)
        {

            for (int j = 0; j < days.Length; j++)
            {
                if (days[j] == testDay)
                {
                    return j;
                }
            }

            throw new System.ArgumentOutOfRangeException(testDay, "testDay must be in the form \"Sun\", \"Mon\", etc");
        }
      
        public int this[string day]
        {
            get
            {
                return (GetDay(day));
            }


        }
        class program
        {
            static void Main(string[] args)
            {
                index2 week = new index2();
                Console.WriteLine(week["wed"]);
                // Raises ArgumentOutOfRangeException
                //Console.WriteLine(week["Made-up Day"]);

                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                Console.Read();
            }
        }
    }
}
