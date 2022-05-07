using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Factors
    {
        public void PrimeFactors()
        {
            Console.Write("Enter a number to find Prime Factors : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime Factors of " + number + " are : ");

            //While the number is divisible by 2 we are dividing it
            while (number % 2 == 0)
            {
                Console.Write(2 + " ");
                number /= 2;
            }

            //This part is for all the odd numbers greater than 2
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    Console.Write(i + " ");
                    number /= i;
                }
            }
            if (number > 2)
            {
                Console.Write(number);
            }

        }
    }
}
