using System;
using System.Collections.Generic;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.) Create a text file that says "This is a text file."
            //string textFile = "This is a stupendous text file.";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            //System.IO.File.WriteAllText(@"C:\testfilewrite\WriteText.txt", textFile);


            //2.) Edit the previous file to say "This is a text file, and I can edit it."
            // string editedText = File.ReadAllText(@"C:\testfilewrite\WriteText.txt");
            // editedText = editedText.Replace(".", ", and I can edit it.");
            // File.WriteAllText(@"C:\testfilewrite\WriteText.txt", editedText);

            //3. Write a program that deletes the previously created file.
            //File.Delete(@"C:\testfilewrite\WriteText.txt");


            //4. Write a program that reads a text file and displays the number of words

            // StreamReader sr = new StreamReader(@"C:\testfilewrite\WriteText.txt");

            // int counter = 0;
            // string delim = " .";
            // string[] fields = null;
            // string line = null;

            // while(!sr.EndOfStream)
            // {
            //     line = sr.ReadLine();
            //     line.Trim();
            //     fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //     counter += fields.Length;
            // }

            // sr.Close();
            // Console.WriteLine("The word count is {0}", counter);


            //5.) Write a program that reads a text file and displays the longest word in file

            // byte[] bytes = System.IO.File.ReadAllBytes(@"C:\testfilewrite\WriteText.txt");
            // string file = System.Text.Encoding.UTF8.GetString(bytes);

            // string[] words = file.Split(new[] {" "}, StringSplitOptions.None);
            //     string word = "";
            //     int counter = 0;
            //     foreach(string s in words)
            //     {
            //         if(s.Length > counter)
            //         {
            //             word = s;
            //             counter = s.Length;
            //         }
            //     }

            //     Console.WriteLine("The longest word in the file is {0}", word);




            // Program to read a random word from list, ask user to guess the word,
            // and tell user if their choice is correct, before, or after the random word
           
            bool boolGuess = false;
            Random rnd = new Random();

            string[] words = File.ReadAllLines(@"C:\testfilewrite\words_alpha.txt");

            int wordIndex = rnd.Next(0, words.Length);
            
            string secretWord = words[wordIndex];
            
            Console.WriteLine("The secret word is: {0}", secretWord);

            Console.WriteLine("Guess a word I have chosen that is in my list and I will tell you if your answer is correct or before or after my word.");
           
            do
            {
                string guess = Console.ReadLine();
                int guessIndex = Array.IndexOf(words, guess);
                if (guessIndex >= 0)
                {
                    int secretWordIndex = Array.IndexOf(words, secretWord);
                    if (guessIndex == secretWordIndex)
                    {
                        System.Console.WriteLine("Good job, you guessed it!");
                        boolGuess = true;
                    }
                    else if (guessIndex < secretWordIndex)
                    {
                        System.Console.WriteLine("Your word choice is before my secret word. Please try again.");
                        boolGuess = false;
                    }
                    else if (guessIndex > secretWordIndex)
                    {
                        System.Console.WriteLine("Your word choice is after my secret word. Please try again.");
                        boolGuess = false;
                    }
                }
                else
                {
                    System.Console.WriteLine("Your word choice is not in my list. Please choose another word.");
                    boolGuess = false;
                }
                
            }while (boolGuess == false);
                    
        }
    }
}
