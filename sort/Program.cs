using System;

namespace sort
{
    class Program
    {
        int[] numbers = {20, 10, 50, 80, 15};
        static void Main(int[] numbers)
        {
            //Console.WriteLine("Hello World!");
            for (int i = 0; i < numbers.Length; i++)
            {
                 if (numbers[i] > numbers[i + 1])
                 {
                     numbers[i + 1] = numbers[0];
                     
                 }
            }
            
        }
    }
}
