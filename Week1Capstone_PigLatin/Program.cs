using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Capstone_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string willContinue = "y";

            Console.WriteLine("Welcome to the Grand Circus pig latin translator!!!");

            do
            {

                Console.Write("Please enter a word to be translated: ");
                string userWord = Console.ReadLine().ToLower();

                Console.WriteLine(Program.TranslateWord(userWord));

                Console.WriteLine();
                Console.WriteLine("Would you like to enter another word?  y or n");
                willContinue = Console.ReadLine();
                Console.WriteLine();

            } while (willContinue.ToLower() == "y");

            Console.WriteLine("This was awesome. Come play again sometime.");
        }




        public static string TranslateWord(string word)
        {
            string vowels = "aeiouAEIOU";
            string answer = null;

            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[0]))
                {
                    answer = word + "way";
                }
                else if (vowels.Contains(word[i]))
                {
                    string firstPart = word.Substring(0, i);
                    string secondPart = word.Substring(i);
                    answer = secondPart + firstPart + "ay";
                    break;
                }

                
            }
            return answer;
        }
    }
}
