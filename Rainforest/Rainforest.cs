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
            // create new instance of containers
            Container Austin1 = new Container(4, "Austin01");
            Container Austin2 = new Container(5, "Austin02");
            Container Dallas1 = new Container(6, "Dallas01");
            Container Dallas2 = new Container(7, "Dallas02");
            // create new instances of items
            Item Item1 = new Item("bananas", 3.00);
            Item Item2 = new Item("cereal", 5.00);
            Item Item3 = new Item("milk", 4.50);
            // add warehouses to the company
            Rainforest.Warehouses.Add(Austin);
            Rainforest.Warehouses.Add(Dallas);
            // add containers to warehosues
            Austin.Containers.Add(Austin1);
            Austin.Containers.Add(Austin2);
            Dallas.Containers.Add(Dallas1);
            Dallas.Containers.Add(Dallas2);
            // add items to containers
            Austin1.Items.Add(Item1);
            Austin2.Items.Add(Item2);
            Dallas2.Items.Add(Item3);

            // call manifest method which prints out warehouse locations, warehouse containers, items in containers
            Manifest(Rainforest);

            // call an index method to get location of item passed in belonging to company passed in
            findItemsContainer(Item1, Rainforest);
            findItemsContainer(Item3, Rainforest);
           

            
        }
        public static void Manifest(Company company)
        { 
             Console.WriteLine("{0}", company.Name);

            foreach(Warehouse warehouse in company.Warehouses)
            {
                Console.WriteLine("{0}".PadLeft(6), warehouse.Location);

                foreach (Container container in warehouse.Containers)
                {
                    Console.WriteLine("{0}".PadLeft(8), container.ID);

                    foreach(Item item in container.Items)
                    {
                        Console.WriteLine("{0}".PadLeft(12), item.Name);
                    }
                }
            }
        }

        public static void findItemsContainer(Item item, Company company)
        {
            Dictionary<Item, Container> indexer = new Dictionary<Item, Container>();

            foreach(Warehouse ware in company.Warehouses)
            {
                foreach(Container cont in ware.Containers)
                {
                    foreach (Item it in cont.Items)
                    {
                        indexer.Add(it, cont);
                    }
                }
            }

            Dictionary<Item, Warehouse> indexer2 = new Dictionary<Item, Warehouse>();
            
            foreach(Warehouse ware in company.Warehouses)
            {
                foreach(Container cont in ware.Containers)
                {
                    foreach (Item it in cont.Items)
                    {
                        indexer2.Add(it, ware);
                    }
                }
            }

            Container indexedContainer = indexer[item];
            Warehouse indexedWarehouse = indexer2[item];
            System.Console.WriteLine("The {0} is located in the {1} container in the {2} warehouse", item.Name, indexedContainer.ID, indexedWarehouse.Location);
        }
        
    }
    class Company
    {
        public string Name {get; set;}
        public List<Warehouse> Warehouses = new List<Warehouse>();
        public Company(string name)
        {
            this.Name = name;
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
