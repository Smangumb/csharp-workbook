using System;

namespace CarGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Car blueCar = new Car();
            Garage smallGarage = new Garage(2);
            Person person1 = new Person("Sam Bostick");

            smallGarage.ParkCar(blueCar, 0);
            Console.WriteLine(smallGarage.Cars);
        }
    }
    class Car
    {
        public Car(string initialColor)
        {
            Color = initialColor;
        }
        public string Color { get; private set; }
        public Car()
        {

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

        public void ParkCar(Car car, int spot)
        {
            cars[spot] = car;
        }
        public string Cars
        {
            get
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i] != null)
                    {
                        Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
                    }
                }
                return "That's all!";
            }
        }
    }
    public class Person
    {
        public Person(string person1)
        {
            Name = person1;
        }

        public string Name { get; private set; }
    }
}
