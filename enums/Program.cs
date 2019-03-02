using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
             foreach (var item in Enum.GetValues(typeof(DaysOfWeek)))
            {
                var dayEnum = (DaysOfWeek)item;
                System.Console.WriteLine(dayEnum.ToString());
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
