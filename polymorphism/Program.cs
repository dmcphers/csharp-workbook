using System;

namespace polymorphism
{
    public class Program
    {
        public static void Main()
        {
            Motorcycle harley = new Motorcycle("Harley", "FatBoy", 2, false);
            Car civic = new Car("Honda", "Civic", 4, true);
            Truck ford = new Truck("Ford", "F150", 4, 8);
            String motoDesc = harley.GetDescription();
            String carDesc = civic.GetDescription();
            String truckDesc = ford.GetDescription();


            Console.WriteLine(motoDesc);
            System.Console.WriteLine(carDesc);
            System.Console.WriteLine(truckDesc);
            //System.Console.WriteLine(descrip);
           
            // List<Vehicle> inventory = new List<Vehicle>();
            // inventory.Add(harley);
            // inventory.Add(civic);

            // foreach(Vehicle v in inventory)
            // {
            //     // print out description of vehicle
            // }
        }
    }
    public abstract class Vehicle
    {
        public String Make;
        public String Model;
        public int NumWheels;
        public Vehicle(String make, String model, int numWheels)
        {
            this.Make = make;
            this.Model = model;
            this.NumWheels = numWheels;
        }
        // public String GetDescription()
        // {
        //     String desc = String.Format("The vehicle is a ")
        // }

        // this means all vehicles must include getdescription method
        //abstract public String GetDescription();
    }
    public class Motorcycle : Vehicle
    {
        bool IsCruiser;
        public Motorcycle(String Make, String Model, int NumWheels, bool isCruiser):base(Make, Model, NumWheels)
        {
            this.IsCruiser = isCruiser;
        }
        public String GetDescription()
        {
            String desc = "The motorcycle is a " + Make + " " + Model +" with " + NumWheels + " wheels and " + (IsCruiser ? "is" : "is not") + " a cruiser";
            return desc;
        }
        // public string GetDescription()
        // {
        //     string message = "returned message";
        //     return message;
        // }
    }
    public class Car : Vehicle
    {
        bool IsConvertible;
        public Car(String Make, String Model, int NumWheels, bool isConvertible):base(Make, Model, NumWheels)
        {
            this.IsConvertible = isConvertible;
        }
        public String GetDescription()
        {
            String desc = "The car is a " + Make + " " + Model +" with " + NumWheels + " wheels and " + (IsConvertible ? "is" : "is not") + " a convertible";
            return desc;
        }
    }
    public class Truck : Vehicle
    {
        int BedSize;
        public Truck(String Make, String Model, int NumWheels, int bedSize):base(Make, Model, NumWheels)
        {
            this.BedSize = bedSize;
        }
        public String GetDescription()
        {
            String desc = "The truck is a " + Make + " " + Model + " with " + NumWheels + " wheels and the bed size is " + BedSize + " foot";
            return desc;
        }
    }

}
