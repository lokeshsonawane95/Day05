using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class QuotientAndRemainder
    {
        public void QuotientRemainder()
        {
            Console.Write("Enter the dividend number to calculate the Quotiend and Remainder : ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            //Quotient logic
            int quotient = dividend / divisor;

            //Remainder logic
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Remainder is : " + remainder);
        }
    }
}
