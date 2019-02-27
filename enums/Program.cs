using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine(DaysOfWeek.Monday);
            // System.Console.WriteLine(DaysOfWeek.Tuesday);
            // System.Console.WriteLine(DaysOfWeek.Wednesday);
            // System.Console.WriteLine(DaysOfWeek.Thursday);
            // System.Console.WriteLine(DaysOfWeek.Friday);
            // System.Console.WriteLine(DaysOfWeek.Saturday);
            // System.Console.WriteLine(DaysOfWeek.Sunday);
            // System.Console.WriteLine();

            
            // foreach (var item in Enum.GetValues(typeof(System.DayOfWeek)))
             foreach (var item in Enum.GetValues(typeof(DaysOfWeek)))
            {
                var monthEnum = (DaysOfWeek)item;
                System.Console.WriteLine(monthEnum.ToString());
            }
        }

    
        enum DaysOfWeek
            {
                Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
            }

        public struct structPoint
        {

            public structPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
          public int X { get; set;}
          public int Y { get; set;}
        }
    }
}
