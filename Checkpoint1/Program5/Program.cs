using System;
using System.Collections;

namespace program5
{
    class Program
    {
            public static void Main()
            {

                // set sort to false for initialization purposes
                bool sort = false;
                // prompt user to enter a series of numbers separated by commas
                Console.WriteLine("Please enter a series of numbers separated by commas");
                // read the user input into a string variable
                string numbers = Console.ReadLine();
                // separate the string into an array based on commas between numbers
                string[] strNumbersArr = numbers.Split(',');
                // initialize an integer array with the same length as the previous string array
                int[] intNumbersArr = new int[strNumbersArr.Length];
                // display first part of a message that shows user numbers they entered
                Console.WriteLine("The numbers you entered were: ");

            // loop through string array and assign the intNumbersArr index the int value of strNumberArr index
            for (int i = 0; i < strNumbersArr.Length; i++)
                {
                    intNumbersArr[i] = int.Parse(strNumbersArr[i]);
                }
            
            // output each index of the intNumbersArr
            for (int i = 0; i < intNumbersArr.Length; i++)
            {
                Console.WriteLine(intNumbersArr[i]);
            }

            // pass in intNumbersArr to findGreatest function and assign result to greatestNum
            int greatestNum = findGreatest(intNumbersArr, sort);
            
            // display message showing the greatest number of numbers that user entered
            Console.WriteLine("The greatest number out of the numbers you entered is: {0}", greatestNum);
            
                
                       
        }

        // function to find the greatest number in an array of numbers
        public static int findGreatest(int[] intNumbersArr, bool sort)
            {
                 // loop through array
                        for (int i = 0; i < intNumbersArr.Length - 1; i++)
                        {
                            // set current position in array to variable current and next position in array to variable next
                            int current = intNumbersArr[i];
                            int next = intNumbersArr[i + 1];
                             
                            // if number in current index is greater than or equal to next position, then
                            // set current to next and next to current (switch them), and set sort to false since
                            // array is not sorted yet if any switching positions takes place
                            if (intNumbersArr[i] >= intNumbersArr[i + 1])
                            {
                                intNumbersArr[i] = next;
                                intNumbersArr[i + 1] = current;
                                sort = false;
                            }
                            // if number in current index is less than number of next position, then set 
                            // current index number to the variable current and set sort to true to continue 
                            // looping through the array to search for sorting necessity
                            else if (intNumbersArr[i] < intNumbersArr[i + 1 ])
                            {
                                intNumbersArr[i] = current;
                                sort = true;
                            }
                            // if sort is not equal to true, then set counter to -1 so that for loop will begin
                            // at index 0 again
                                if (!sort)
                                {
                                    i = -1;
                                }
                            
                        }
                
                // when array has been sorted, return the last number in the array - which will be the greatest - to the
                // function call in main
                return intNumbersArr[intNumbersArr.Length - 1];
            }
    }
}
