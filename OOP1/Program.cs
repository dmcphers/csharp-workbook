using System;
using System.Collections.Generic;

namespace OOP1
{
    class Program
    {
        public static void Main()
        {
         
        Car blueCar = new Car("blue");
        Person male = new Person("John");
        Person female = new Person("Jane");

		Garage smallGarage = new Garage(2);
		
        // pass in person instance to spot in the car
        blueCar.addPerson(male, 0);
        blueCar.addPerson(female, 1);


        // passing in instance of car to garage spot
	    smallGarage.ParkCar(blueCar, 0);


        Console.WriteLine(smallGarage.Cars);
        
		
        }
    }

    class Car
    {
        public Car(string initialColor)
        {
            Color = initialColor;
            this.passengers = new List <Person>();
            // change to list
        }
        
        public string Color { get; private set; }

        public List <Person> passengers;

        // add person to passenger array and place in spot of car
        public void addPerson (Person passenger, int spot)
        {
           passengers.Add(passenger);
        }

        public string Passengers {
            get {
                string passengerNames = "";
                for (int i = 0; i < passengers.Count; i++)
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
        
        // passes car instance into cars array and in particular spot of garage
        public void ParkCar (Car car, int spot)
        {
            cars[spot] = car;
        }
        
        // prints out the cars in list with their color, spot in garage, and people in car
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
