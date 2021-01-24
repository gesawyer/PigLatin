using System;
namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again == true)

            {
                Console.WriteLine("Welcome to the Pig Latin generator.Please enter a word.");
                string word = Console.ReadLine();
                string lowerWord = word.ToLower();
                if (word.Trim() == "")
                {
                    Console.WriteLine("Uh-oh! Try again with a word this time.");
                }
                char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
                char[] cons = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
                int startsCon = lowerWord.IndexOfAny(cons);
                int startsVow = lowerWord.IndexOfAny(vowel);
                if (startsVow == 0)
                {
                    Console.WriteLine(lowerWord + "way");
                }
                else if (startsCon == 0)
                {
                    string firstHalf = lowerWord.Substring(0, startsVow);
                    string secondHalf = lowerWord.Substring(startsVow);
                    Console.WriteLine(secondHalf + firstHalf + "ay");
                }
                again = GoAgain();
            }
            static bool GoAgain()
            {
                Console.WriteLine("Would you like to continue? Y/N");
                string response = Console.ReadLine();
                string lowResponse = response.ToLower();

                if (lowResponse == "y")
                {
                    return true;
                }
                else if (lowResponse == "n")
                {
                    Console.WriteLine("Thanks for playing, iendfray!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Sorry- I didn't understand. Please try again.");
                    return GoAgain();
                }
            }
        }
    }
}




