using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Please enter your birthday in format of yyyy, mm, dd:");
            // string strDate = Console.ReadLine();
            // DateTime dt = new DateTime();
            // dt = DateTime.Parse(strDate);
            // //DateTime dt = new DateTime(2019, 2, 19);
            // //System.Console.WriteLine("Your birtday is {0}", dt);
            // System.Console.WriteLine("The day of the week of your birthday for the year {0} is {1}",dt.Year, dt.DayOfWeek);
            System.Console.WriteLine(DaysOfWeek.Monday);
            System.Console.WriteLine(DaysOfWeek.Tuesday);
            System.Console.WriteLine(DaysOfWeek.Wednesday);
            System.Console.WriteLine(DaysOfWeek.Thursday);
            System.Console.WriteLine(DaysOfWeek.Friday);
            System.Console.WriteLine(DaysOfWeek.Saturday);
            System.Console.WriteLine(DaysOfWeek.Sunday);
            System.Console.WriteLine();

            
             foreach (var item in Enum.GetValues(typeof(System.DayOfWeek)))
            {
                var monthEnum = (DayOfWeek)item;
                System.Console.WriteLine(monthEnum.ToString());
            }
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
          public static void CalculateValue()
          {
              
          }
        }

}
