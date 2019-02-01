using System;

namespace sort
{
    class Program
    {
        static void Main()
        {
            // set sort to false and initialize array with bunch of unsorted numbers
            bool sort = false;
            int[] numbers = new int[]{25,75,12,24,48,88,344,3,159,77};
                    // loop through array
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        // set current position in array to variable current and next position in array to variable next
                        int current = numbers[i];
                        int next = numbers[i + 1];

                        // if number in current index is greater than or equal to next position, then
                        // set current to next and next to current (switch them), and set sort to false
                        if (numbers[i] >= numbers[i + 1])
                        {
                           numbers[i] = next;
                           numbers[i + 1] = current;
                           sort = false;
                        }
                        // if number in current index is less than number of next position, then set 
                        // current index number to the variable current and set sort to true
                        else if (numbers[i] < numbers[i + 1])
                        {
                            numbers[i] = current;
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
            for (int i = 0; i < numbers.Length; i++)
            {
                 System.Console.WriteLine(numbers[i]);
            }
        }
    }
}
