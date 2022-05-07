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
            Console.WriteLine("4. Harmonic Number");
            Console.WriteLine("5. Factors");
            Console.WriteLine("6. Quotient and Remainder");
            Console.WriteLine("7. Swap Two Numbers");
            Console.WriteLine("8. Even or Odd");
            Console.WriteLine("9. Alphabet is Vowel or Consonant");

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
                case 4:
                    HarmonicNumber hn = new HarmonicNumber();
                    hn.Harmonic();
                    break;
                case 5:
                    Factors factors = new Factors();
                    factors.PrimeFactors();
                    break;
                case 6:
                    QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                    quotientAndRemainder.QuotientRemainder();
                    break;
                case 7:
                    SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
                    swapTwoNumbers.Swap();
                    break;
                case 8:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.EvenOdd();
                    break;
                case 9:
                    VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
                    vowelOrConsonant.VowelConsonant();
                    break;
                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;
            }
        }
    }
}