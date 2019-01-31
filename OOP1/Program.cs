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
        
        blueCar.addPerson(male);
		
		smallGarage.ParkCar(blueCar, 0);
		Console.WriteLine(smallGarage.Cars);
        }
        
    }

    class Car
    {
        public Car(string initialColor)
        {
            Color = initialColor;
            passengers = new Person[1];
        }
        
        public string Color { get; private set; }

        private Person[] passengers;

        public void addPerson (Person passenger)
        {
            this.passengers[0] = passenger;
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
                        Console.WriteLine(String.Format("The {0} car is in spot {1}. ", cars[i].Color, i));
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
