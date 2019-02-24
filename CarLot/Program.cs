using System;
using System.Collections.Generic;


namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot samCarlot = new CarLot("Sam's Carlot");
            CarLot lameCarlot = new CarLot("Lame Carlot");
            Truck truck1 = new Truck("B8D3F20", "Ford", "150", 15000, 7);
            Truck truck2 = new Truck("K39C0W", "Chevy", "Silverado", 16000, 6);
            Car car1 = new Car("Sedan", 4, "67BN21", "Nissan", "Altima", 14500);
            Car car2 = new Car("Hatchback", 2, "KO92LO", "Honda", "Civic", 19450);
            samCarlot.AddVehicle(truck1);
            samCarlot.AddVehicle(car1);
            lameCarlot.AddVehicle(truck2);
            lameCarlot.AddVehicle(car2);
            samCarlot.PrintInventory();
            lameCarlot.PrintInventory();
        }
    }
    public class CarLot
    {
        //name prop
        string Name { get; set; }
        //list <vehicle>
        List<Vehicle> Vehicles = new List<Vehicle>();

        public CarLot(string name)
        {
            this.Name = name;
        }
        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
        public void PrintInventory()
        {
            System.Console.WriteLine($"There are {Vehicles.Count} vehicles");
            foreach (var vehicle in Vehicles)
            {
                vehicle.PrintDescription();
            }

        }
    }
    public abstract class Vehicle
    {
        public abstract string LicenseNumber { get; set; }
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract double Price { get; set; }

        public abstract void PrintDescription();
    }
    public class Truck : Vehicle
    {
        //5 properties
        int BedSize { get; set; }
        public override string LicenseNumber { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override double Price { get; set; }
        public Truck(string licenseNumber, string make, string model, double price, int bedSize)
        {
            this.LicenseNumber = licenseNumber;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.BedSize = bedSize;
        }
        public override void PrintDescription()
        {
            System.Console.WriteLine("The truck is a {0} {1} with the license plate {2}. It has a truck bed of {3}ft. It costs {4}", Make, Model, LicenseNumber, BedSize, Price);
        }

    }
    public class Car : Vehicle
    {
        // 6 properties
        string Type { get; set; }
        int NumDoors { get; set; }
        public override string LicenseNumber { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override double Price { get; set; }
        public Car(string type, int numDoors, string licenseNumber, string make, string model, double price)
        {
            this.Type = type;
            this.NumDoors = numDoors;
            this.LicenseNumber = licenseNumber;
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }
        public override void PrintDescription()
        {
            System.Console.WriteLine("The car is a {0} {1} with the license plate {2}. It is a {3}. It has {4} doors. It costs {5}", Make, Model, LicenseNumber, Type, NumDoors, Price);
        }

    }
}
