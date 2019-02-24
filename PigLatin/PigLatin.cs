using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // get input sentence from user and assign it to an array
            string[] words = Console.ReadLine().Split(" ");
            
            // pass in the user input array to the TranslateWord function
            TranslateWord(words);


            // HAVE NOT COMPLETED THIS FUNCTIONALITY YET
            //bool hasPunctuation = CheckForPunctuation(pglsentence);

        
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string TranslateWord(string[] words)
        {
            // create a piglatin words array that is the length of the user input array
            string[] pglwords = new string[words.Length];

            //for each word in the array, find first instance of a vowel
            for (int i = 0; i < words.Length; i++)
            {
                int firstVowelIndex = words[i].IndexOfAny(new char[]{'a','e','i','o','u','y'});
                //if vowel is in first position, add 'yay' to end of word
                if (firstVowelIndex == 0)
                {
                    pglwords[i] = words[i] + "yay";
                }
                // if there is no vowel in the word, add 'ay' to end of word
                else if(firstVowelIndex == -1)
                    {
                        pglwords[i] = words[i] + "ay";
                    }
                else
                // separate the word into beginning of word through first vowel, and first vowel through end of word
                // then join together the word with second part + first part + letters 'ay' 
                {
                    string firstPart = words[i].Substring(0, firstVowelIndex);
                    string secondPart = words[i].Substring(firstVowelIndex);
                    string result = (secondPart + firstPart + "ay");
                    pglwords[i] = result;
                }
            }
            // join together all the words in the array separated by spaces
            string pglsentence = String.Join(" ", pglwords);
            

            // print out the user's input sentence translated to pig latin
            Console.WriteLine(pglsentence.ToLower());
            return pglsentence;
        }

        // HAVE NOT COMPLETED THIS FUNCTIONALITY YET

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
