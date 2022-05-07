using System;

namespace Day05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the choice");
            Console.WriteLine("1. Flip Coin and print percentage of Heads and Tails");
            Console.WriteLine("2. Leap Year");
            Console.WriteLine("3. Power of 2");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FlipCoin fp = new FlipCoin();
                    fp.Coin();
                    break;
                case 2:
                    LeapYear ly = new LeapYear();
                    ly.Year();
                    break;
                case 3:
                    PowerOfTwo pw = new PowerOfTwo();
                    pw.Power();
                    break;
                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;
            }
        }
    }
}