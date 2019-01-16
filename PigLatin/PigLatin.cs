using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            string word = Console.ReadLine();
            string firstLetter = word.Substring(0,1);
            int firstLetterIndex = word.IndexOf(firstLetter);
            //Console.WriteLine(firstLetterIndex);
            string restWord = word.Substring(firstLetterIndex + 1);
            Console.WriteLine(restWord + firstLetter + "ay");


            //Console.WriteLine(restWord);
            // leave this command at the end so your program does not close automatically
            //Console.ReadLine();
        }
        
        public static string TranslateWord(string word)
        {
            // your code goes here
            return word;
        }
    }
}
