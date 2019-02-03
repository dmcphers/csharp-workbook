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
		
	    smallGarage.ParkCar(blueCar, 0);
        Console.WriteLine(smallGarage.Cars);
        blueCar.addPerson(male, 0);
        System.Console.WriteLine(blueCar.Passengers);
		
        }
        
    }

    class Car
    {
        public Car(string initialColor)
        {
            Color = initialColor;
            this.passengers = new Person[1];
        }
        
        public string Color { get; private set; }

        public Person[] passengers;

        public void addPerson (Person passenger, int spot)
        {
           passengers[spot] = passenger;
        }

        public string Passengers {
            get {
                for (int i = 0; i < passengers.Length; i++)
                {
                    if (passengers[i] != null) {
                        Console.WriteLine(String.Format("You have added {0} to the car", passengers[i].Name));
                    }
                }
                return "That's all!";
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
                        Console.WriteLine(String.Format("The {0} car is in spot {1}", cars[i].Color, i));
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
