using System;

namespace Day05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the choice");
            Console.WriteLine("1. Flip Coin and print percentage of Heads and Tails");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FlipCoin fp = new FlipCoin();
                    fp.Coin();
                    break;
                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;
            }
        }
    }
}