using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Person leia = new Person("Leia", "Organa", "Rebel");
		Person darth = new Person("Darth", "Vader", "Imperial");
		Person luke = new Person("Luke", "Skywalker", "Rebel");
		Person han = new Person("Han", "Solo", "Rebel");
		Ship x = new Ship("Xwing", "Rebel", "Fighter", 2);
		Ship falcon = new Ship("MilFalcon","Rebel", "Smuggling", 2);
		Ship tie = new Ship("TieFighter","Tie", "Fighter", 1);
        Station enterprise = new Station("RebelStation", "Rebel", 5);
		Station darkside = new Station("DeathStar", "Imperial", 5);
		//Console.WriteLine("Hello world!");

        enterprise.DockShip(1, falcon);
		enterprise.DockShip(2, x);
		enterprise.unDockShip(1, falcon);

		x.EnterShip(luke, 0);
		x.EnterShip(leia, 1);
        
		enterprise.Roster();
	}
}

class Person
{
	private string firstName;
	private string lastName;
	private string alliance;
	public Person(string firstName, string lastName, string alliance)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.alliance = alliance;
	}

	public string FullName
	{
		get
		{
			return this.firstName + " " + this.lastName;
		}

		set
		{
			string[] names = value.Split(' ');
			this.firstName = names[0];
			this.lastName = names[1];
		}
	}
}

class Ship
{
	private Person[] passengers;
    
    public string Name { get; set; }
    
	public Ship(string name, string alliance, string type, int size)
	{
		this.Name = name;
		this.Type = type;
		this.Alliance = alliance;
		this.passengers = new Person[size];
	}

	public string Type
	{
		get;
		set;
	}

	public string Alliance
	{
		get;
		set;
	}

	public string Passengers
	{
		get
		{
			foreach (var person in passengers)
			{
				Console.WriteLine(String.Format("{0}", person.FullName));
			}

			return "That's Everybody!";
		}
	}

	public void EnterShip(Person person, int seat)
	{
		this.passengers[seat] = person;
		System.Console.WriteLine("{0} has entered seat {1} of {2}", person.FullName, seat, this.Name);
	}

	public void ExitShip(int seat)
	{
		this.passengers[seat] = null;
	}
}

class Station 
{
public string Name {get; set;}
	public string Alliance {get; set;}
	public int Size {get; set;}
	public Dictionary<int, Ship> Docked = new Dictionary<int, Ship>();

	public Station(string name, string alliance, int size)
    {
        this.Name = name;
        this.Alliance = alliance;
    }

	public void DockShip(int port, Ship ship)
	{
		Docked.Add(port, ship);
		System.Console.WriteLine("{0} is docked in port {1} of {2}", ship.Name, port, this.Name);
	}

	public void unDockShip(int port, Ship ship)
	{
		Docked.Remove(port);
		System.Console.WriteLine("{0} has been removed from port {1} of {2}", ship.Name, port, this.Name);
		System.Console.WriteLine("The following ships and their corresponding ports remain: ");
		foreach(KeyValuePair<int, Ship> pair in Docked)
		{
			System.Console.WriteLine("{0} , {1}", pair.Value.Name, pair.Key);
		}
	}
	public void Roster()
	{
		foreach(KeyValuePair<int, Ship> pair in Docked)
		{
			System.Console.WriteLine("Ship {0} contains: ", pair.Value.Name);
			System.Console.WriteLine("{0}", pair.Value.Passengers);
		}
	}
}
