using System;
using System.Collections.Generic;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Console.WriteLine("Hello World!");
            // List<string> words = new List<string>{"cat", "ba", "dog"};
            // List<string> result = moreThanThree(words);
            // foreach (var r in result)
            // {
            //     System.Console.WriteLine(r);
            // }
            // string text = "A class is the most powerful data type in C#. Like a structure, " +
            //            "a class defines the data and behavior of the data type. ";
            // // WriteAllText creates a file, writes the specified string to the file,
            // // and then closes the file.    You do NOT need to call Flush() or Close().
            // System.IO.File.WriteAllText(@"C:\testfilewrite\WriteText.txt", text);


           simpleWay(args);


        }
        
        private static void simpleWay(string[] args)
        {
             string textToWrite = string.Join(" ", args);

            string documentsPath =  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string documentName = "simple way";
            string documentExtension = ".txt";
            string fullPathToFile = $"{documentsPath}\\{documentName}.{documentExtension}";
            System.IO.File.WriteAllText(fullPathToFile, textToWrite);

            System.Console.WriteLine($"Press any key to close {documentName}.{documentExtension} file");
            System.Console.ReadLine();
        }
        // public static List<string> moreThanThree(IEnumerable<string> input)
        // {
        //     List<string> results = new List<string>();
        //     foreach (var i in input)
        //     {
        //         if (i.Length > 2)
        //         {
        //             results.Add(i);
        //         }
                
        //     }
        //     return results;
        // }
    }
}
