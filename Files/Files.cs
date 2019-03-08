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

            Random rnd = new Random();

            byte[] bytes = System.IO.File.ReadAllBytes(@"C:\testfilewrite\words_alpha.txt");
            string file = System.Text.Encoding.UTF8.GetString(bytes);

            //string[] words = File.ReadAllLines(@"C:\testfilewrite\words_alpha.txt");

            //file = file.Replace("\n", String.Empty);

            string[] words = file.Split("\n");
            // Console.WriteLine("The array of words length is: {0}", words.Length);
            // foreach (string w in words)
            // {
            //     w.Remove(w.Length - 2);
            // }

            int wordIndex = rnd.Next(0, words.Length);
            //string[] charstotrim = {" ","\n"};
            string secretWord = words[wordIndex];
            //int wordIndex = 1;
            Console.WriteLine("The secret word is: {0}", secretWord);

            Console.WriteLine("Guess a word I am thinking of and I will tell you if it is correct or before or after my word.");
            string guess = Console.ReadLine();
            Console.WriteLine(guess.GetType());
            Console.WriteLine(secretWord.GetType());
            Console.WriteLine(guess.Length);
            Console.WriteLine(secretWord.Length);
            Console.WriteLine(guess);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(secretWord);
            Console.ResetColor();

            //         if (guess.Length != secretWord.Length)
            // throw new Exception("Well here's the problem");

            // for (int i = 0; i < secretWord.Length; i++) {
            //     if (secretWord[i] != guess[i]) {
            //         throw new Exception("Difference at character: " + i+1);
            //     }
            // }

            Console.WriteLine(guess.Equals(secretWord));
            if (string.Equals(guess, secretWord))
            {
                Console.WriteLine("That is correct");
            }
            // else if (guess == words[wordIndex])
            // {
            //     Console.WriteLine("You got it!!!");
            // }
                    
        }
    }
}
