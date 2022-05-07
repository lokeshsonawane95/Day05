using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class LeapYear
    {
        public void Year()
        {
            Console.Write("Enter a 4 digit year : ");
            uint year = Convert.ToUInt32(Console.ReadLine());

            //Checking if the entered value is 4 digit or not
            if (year > 999 && year <= 9999)
            {
                //Leap Year condition
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine("Year is Leap Year");
                }
                else
                {
                    Console.WriteLine("Year is not Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Entered year is not 4 digit");
            }

        }
    }
}
