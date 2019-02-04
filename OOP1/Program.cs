using System;

namespace OOP1
{
    class Program
    {
        public static void Main()
        {
            // {
        //     Console.WriteLine("Hello World!");
        // }
        Car blueCar = new Car("blue");
        Person male = new Person("John");
        Person female = new Person("Jane");

		Garage smallGarage = new Garage(2);
		
        blueCar.addPerson(male, 0);
        blueCar.addPerson(female, 1);
	    smallGarage.ParkCar(blueCar, 0);
        Console.WriteLine(smallGarage.Cars);
        //System.Console.WriteLine(blueCar.Passengers);
		
        }
    }

    class Car
    {
        public Car(string initialColor)
        {
            Color = initialColor;
            this.passengers = new Person[2];
        }
        
        public string Color { get; private set; }

        public Person[] passengers;

        public void addPerson (Person passenger, int spot)
        {
           passengers[spot] = passenger;
           //System.Console.WriteLine(passenger);
        }

        public string Passengers {
            get {
                string passengerNames = "";
                for (int i = 0; i < passengers.Length; i++)
                {
                    if (passengers[i] != null) {
                        passengerNames += passengers[i].Name + " ";
                    }
                }
                return passengerNames;
            }
        }

    }

    class Garage
    {
        private Car[] cars;
        
        public Garage(int initialSize)
        {
            Size = initialSize;
            this.cars = new Car[initialSize];
        }
        
        public int Size { get; private set; }
        
        public void ParkCar (Car car, int spot)
        {
            cars[spot] = car;
        }
        
        public string Cars {
            get {
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i] != null) {
                        Console.WriteLine(String.Format("The {0} car is in spot {1} and the people in that car are: {2}", 
                            cars[i].Color, i, cars[i].Passengers));
                    }
                }
                return "That's all!";
            }
        }
    }

    class Person
    {
        public Person(string initialName)
        {
            Name = initialName;
        }
        public string Name { get; private set; }
    }
}
