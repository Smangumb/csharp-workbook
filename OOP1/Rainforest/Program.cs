using System;
using System.Collections.Generic;


namespace Rainforest
{
    class Program
    {
        static void Main(string[] args)
        {
            Company rainForest = new Company("RainForest");
            Warehouse w1 = new Warehouse("Austin", 10);
            Warehouse w2 = new Warehouse("Houston", 15);
            rainForest.Warehouses.Add(w1);
            rainForest.Warehouses.Add(w2);
            Container austin1 = new Container("Austin-1", 3, 0);
            Container austin2 = new Container("Austin-2", 3, 1);
            Container houston1 = new Container("Houston-1", 3, 2);
            Container houston2 = new Container("Houston-2", 3, 3);
            w1.Containers.Add(austin1);
            w1.Containers.Add(austin2);
            w2.Containers.Add(houston1);
            w2.Containers.Add(houston2);
            Item bananas = new Item("Bananas", 2.99);
            Item apples = new Item("Apples", 1.50);
            Item watermelon = new Item("Walermelon", 4.99);
            Item grapes = new Item("grapes", 1.99);
            austin1.Items.Add(bananas);
            austin2.Items.Add(apples);
            houston1.Items.Add(watermelon);
            houston2.Items.Add(grapes);
            Dictionary<string, string> index = new Dictionary<string, string>();

            System.Console.WriteLine(String.Format("{0} Company Manifest:", rainForest.Name));


            foreach (var warehouse in rainForest.Warehouses)
            {
                System.Console.WriteLine(String.Format("This is the location of the Warehouse: {0}", warehouse.location));
                foreach (var container in warehouse.Containers)
                {
                    System.Console.WriteLine(String.Format("The container in this Warehouse: {0}", container.name));
                    foreach (var item in container.Items)
                    {
                        index.Add(item.name, container.name);
                        System.Console.WriteLine(String.Format("The item in the Container: {0} = ${1}", item.name, item.price));
                    }
                }
            }
            System.Console.WriteLine("Hey what do you want to look for?");
            string userinput = Console.ReadLine().ToLower();


            foreach (var i in index)
            {
                if (userinput == i.Key.ToLower())
                {
                    System.Console.WriteLine("Here is where they are: {0}", i.Value);
                }
            }
        }
    }

    class Company
    {
        public string Name { get; set; }
        public List<Warehouse> Warehouses = new List<Warehouse>();
        public Company(string name)
        {
            this.Name = name;
        }

    }

    class Warehouse
    {
        public string location { get; set; }
        public int size { get; set; }
        public List<Container> Containers = new List<Container>();
        public Warehouse(string location, int size)
        {
            this.location = location;
            this.size = size;
        }
    }

    class Container
    {
        public string name { get; set; }
        public int size { get; set; }
        public int id { get; set; }
        public List<Item> Items = new List<Item>();
        public Container(string name, int size, int id)
        {
            this.name = name;
            this.size = size;
            this.id = id;
        }
    }

    class Item
    {
        public string name { get; set; }
        public double price { get; set; }
        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
