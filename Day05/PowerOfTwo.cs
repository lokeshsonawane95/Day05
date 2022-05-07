using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class PowerOfTwo
    {
        public void Power()
        {
            Console.Write("Enter the power of 2 i.e., value of N (Keep  0 <= N < 31 since 2^31 overflows an int): ");
            try
            {
                uint N = Convert.ToUInt32(Console.ReadLine());
                if (N >= 0 && N < 31)
                {

                    for (int i = 0; i <= N; i++)
                    {
                        Console.WriteLine("The value 2^" + i + " is : " + Math.Pow(2, i));
                    }
                }
                else
                {
                    Console.WriteLine("Entered value is too large to handle");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Entered value is negative");
            }


        }
    }
}
