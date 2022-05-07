using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class LargestAmongThree
    {
        public void Largest()
        {
            Console.Write("Enter 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            //1st number is largest
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("1st number " + num1 + " is Largest");
            }

            //2nd number is largest
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("2nd number " + num2 + " is Largest");
            }

            //3rd number is largest
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("3rd number " + num3 + " is Largest");
            }

            //Entered numbers are equal
            else
            {
                Console.WriteLine("Entered numbers are equal");
            }
        }
    }
}
