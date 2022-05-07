using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class SwapTwoNumbers
    {
        public void Swap()
        {
            Console.Write("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter first number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number1 = " + num1 + "\tNumber2 = " + num2);

            //Swap logic
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping\nNumber1 = " + num1 + "\tNumber2 = " + num2);
        }
    }
}
