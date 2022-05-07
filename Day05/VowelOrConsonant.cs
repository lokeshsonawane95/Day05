using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class VowelOrConsonant
    {
        public void VowelConsonant()
        {
            //Declaring array for vowels
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            Console.Write("Enter an alphabet to check if it's a Vowel or a Consonant : ");
            char c = Convert.ToChar(Console.Read());
            Console.WriteLine("Value entered is : " + c);
            Console.WriteLine("vowels.Contains(c) : " + vowels.Contains(c));

            //Checking if entered character is vowel or not
            if (vowels.Contains(c))
            {
                Console.WriteLine("Entered alphabel is a Vowel");
            }

            //Checking if entered character is alphabel and if it's a other than vowel i.e., a consonant or not
            else if (Char.IsLetter(c) && !vowels.Contains(c))
            {
                Console.WriteLine("Entered alphabel is a Consonant");
            }

            //Otherwise it is neither vowel nor consonant
            else
            {
                Console.WriteLine("Entered value is neither Vowel nor Consonant");
            }

        }
    }
}
