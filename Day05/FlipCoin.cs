using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class FlipCoin
    {
        public void Coin()
        {
            //Declaration of Random variable
            Random random = new Random();

            //To count the number of heads and tails
            int heads = 0, tails = 0;
            Console.Write("Enter the number of times to Flip Coin : ");

            //To take input as unsigned i.e. positive integer value
            int times = Convert.ToInt32(Console.ReadLine());
            if (times > 0)
            {
                for (int i = 0; i < times; i++)
                {
                    float flip = (float)random.NextDouble();
                    Console.WriteLine(flip);
                    if (flip < 0.5)
                    {
                        Console.WriteLine("Tails");
                        heads++;
                    }
                    else
                    {
                        Console.WriteLine("Heads");
                        tails++;
                    }
                }

                //Calculating the percentage appearances of heads and tails
                float headsPercentage = (float)heads / (float)times * 100;
                float tailsPercentage = (float)tails / (float)times * 100;
                Console.WriteLine("Heads appeared : " + headsPercentage + "%");
                Console.WriteLine("Tails appeared : " + tailsPercentage + "%");
            }
            else
            {
                Console.WriteLine("Entered negative value");
            }
        }
    }
}
