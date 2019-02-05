using System;

namespace program5
{
    class Program
    {
            public static void Main()
            {

            // set sort to false and initialize array with bunch of unsorted numbers
            bool sort = false;
            Console.WriteLine("Please enter a series of numbers separated by commas");
            string numbers = Console.ReadLine();
            string[] strNumbersArr = numbers.Split(',');
            int[] intNumbersArr = new int[strNumbersArr.Length];
            Console.WriteLine("The numbers you entered were: ");
            for (int i = 0; i < strNumbersArr.Length; i++)
            {
                //Console.WriteLine(numbersArr[i]);
                intNumbersArr[i] = int.Parse(strNumbersArr[i]);
            }
            
            for (int i = 0; i < intNumbersArr.Length; i++)
            {
                Console.WriteLine(intNumbersArr[i]);
                //intNumbersLi[i] = int.Parse(strNumbersArr[i]);
            }

            int greatestNum = findGreatest(intNumbersArr, sort);
            
            Console.WriteLine("The greatest number out of the numbers you entered is: {0}", greatestNum);
            
                
                       
        }

        public static int findGreatest(int[] intNumbersArr, bool sort)
            {
                 // loop through array
                        for (int i = 0; i < intNumbersArr.Length - 1; i++)
                        {
                            // set current position in array to variable current and next position in array to variable next
                            int current = intNumbersArr[i];
                            int next = intNumbersArr[i + 1];

                            // if number in current index is greater than or equal to next position, then
                            // set current to next and next to current (switch them), and set sort to false
                            if (intNumbersArr[i] >= intNumbersArr[i + 1])
                            {
                            intNumbersArr[i] = next;
                            intNumbersArr[i + 1] = current;
                            sort = false;
                            }
                            // if number in current index is less than number of next position, then set 
                            // current index number to the variable current and set sort to true
                            else if (intNumbersArr[i] < intNumbersArr[i + 1])
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
                
                // print out to the console the sorted numbers array
                return intNumbersArr[intNumbersArr.Length - 1];
                    //Console.WriteLine("The greatest number out of the numbers you entered is: {0}", intNumbersArr[intNumbersArr.Length - 1]);
                //for (int i = 0; i < numbers.Length; i++)
            // {
                //     System.Console.WriteLine(numbers[i]);
            // }
            }
    }
}
