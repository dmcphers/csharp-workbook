using System;

namespace sort
{
    class Program
    {
        static void Main()
        {
            bool sort = false;
            int[] numbers = new int[]{3434,1242,8595,2942,293473,92343,987434,46374};
            
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        int current = numbers[i];
                        int next = numbers[i + 1];

                        if (numbers[i] >= numbers[i + 1])
                        {
                           numbers[i] = next;
                           numbers[i + 1] = current;
                           sort = false;
                        }
                        else if (numbers[i] < numbers[i + 1])
                        {
                            numbers[i] = current;
                            sort = true;
                        }
                            if (!sort)
                            {
                                i = 0;
                            }
                        
                    }
         
            for (int i = 0; i < numbers.Length; i++)
            {
                 System.Console.WriteLine(numbers[i]);
            }
        }
    }
}
