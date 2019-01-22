using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            //string word = Console.ReadLine();
            //string firstLetter = word.Substring(0,1);
            // int firstLetterIndex = word.IndexOf(firstLetter);
            // string restWord = word.Substring(firstLetterIndex + 1);
            // Console.WriteLine(restWord + firstLetter + "ay");
            // int firstVowelIndex = word.IndexOfAny(new char[]{'a','e','i','o','u','y'});
            // if (firstVowelIndex == 0)
            // {
            //     Console.WriteLine(word + "yay");
            // }
            //Console.WriteLine(firstVowelIndex);
            // string firstPart = word.Substring(0, firstVowelIndex);
            // string secondPart = word.Substring(firstVowelIndex);
            // string result = (secondPart + firstPart + "ay");
            // Console.WriteLine(result.ToUpper());
            string[] words = Console.ReadLine().Split(" ");
            
            string pglsentence = TranslateWord(words);
            //bool hasPunctuation = CheckForPunctuation(pglsentence);

            

        
            //Console.WriteLine(restWord);
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string TranslateWord(string[] words)
        {
            // your code goes here
            string[] pglwords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                int firstVowelIndex = words[i].IndexOfAny(new char[]{'a','e','i','o','u','y'});
                if (firstVowelIndex == 0)
                {
                    pglwords[i] = words[i] + "yay";
                }
                else if(firstVowelIndex == -1)
                    {
                        pglwords[i] = words[i] + "ay";
                    }
                else
                {
                    string firstPart = words[i].Substring(0, firstVowelIndex);
                    string secondPart = words[i].Substring(firstVowelIndex);
                    string result = (secondPart + firstPart + "ay");
                    pglwords[i] = result;
                }
            }
            string pglsentence = String.Join(" ", pglwords);
            
            Console.WriteLine(pglsentence.ToLower());
            return pglsentence;
        }

        // public static Boolean CheckForPunctuation(string pglsentence)
        // {
        //     string[] pglsentencearray = pglsentence.Split(" ");
        //     for (int i = 0; i < pglsentencearray.Length; i++)
        //     {
        //         Console.WriteLine(pglsentencearray[i] + "test");
        //     }
            
        //     return true;
        // }
    }
}
