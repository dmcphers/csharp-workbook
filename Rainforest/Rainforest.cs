using System;
using System.Collections.Generic;

namespace Rainforest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // create new instance of company
            Company Rainforest = new Company("Rainforest");
            // create new instances of warehouses
            Warehouse Austin = new Warehouse("Austin", 5);
            Warehouse Dallas = new Warehouse("Dallas", 7);
            Container Austin1 = new Container(4, "Austin01");
            Container Austin2 = new Container(5, "Austin02");
            Container Dallas1 = new Container(6, "Dallas01");
            Container Dallas2 = new Container(7, "Dallas02");
            Item Item1 = new Item("banana", 3.00);
            Item Item2 = new Item("cereal", 5.00);
            Item Item3 = new Item("milk", 4.50);
            Rainforest.Warehouses.Add(Austin);
            Rainforest.Warehouses.Add(Dallas);
            Austin.Containers.Add(Austin1);
            Dallas.Containers.Add(Dallas2);
            Austin1.Items.Add(Item1);
            Austin2.Items.Add(Item2);
            Dallas1.Items.Add(Item1);
            Dallas2.Items.Add(Item3);


        }
    }
    class Company
    {
        public string Name {get; set;}
        public List<Warehouse> Warehouses = new List<Warehouse>();
        //public Company(string name, List<string> warehouses)
        public Company(string name)
        {
            this.Name = name;
            //this.Warehouses = warehouses;
        }
    }
    class Warehouse
    {
        public string Location {get; set;}
        public List<Container> Containers = new List<Container>();
        public int Size {get; set;}

        public Warehouse(string location, int size)
        {
            this.Location = location;
            this.Size = size;
        }

    }
    class Container
    {
        public int Size {get; set;}
        public string ID {get; set;}
        public List<Item> Items = new List<Item>();
        public Container(int size, string id)
        {
            this.Size = size;
            this.ID = id;
        }
    }
    class Item
    {
        public string Name {get; set;}
        public double Price {get; set;}
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
