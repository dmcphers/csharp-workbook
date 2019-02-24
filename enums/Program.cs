using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter your birthday in format of yyyy, mm, dd:");
            string strDate = Console.ReadLine();
            DateTime dt = new DateTime();
            dt = DateTime.Parse(strDate);
            //DateTime dt = new DateTime(2019, 2, 19);
            //System.Console.WriteLine("Your birtday is {0}", dt);
            System.Console.WriteLine("The day of the week of your birthday was {0}", dt.DayOfWeek);
        }
    }
}
