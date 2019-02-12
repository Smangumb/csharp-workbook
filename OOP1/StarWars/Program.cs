using System;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        Person leia = new Person("Leia", "Organa", "Rebel");
        Person darth = new Person("Darth", "Vader", "Imperial");
        Person luke = new Person("Luke", "Skywalker", "Rebel");
        Person solo = new Person("Han", "Solo", "Rebel");
        Person vader = new Person("Darth", "Vader", "Imperial");
        Person emperor = new Person("Emperor", "Palpatine", "Imperial");
        Ship falcon = new Ship("Rebel", "Smuggling", 2);
        Ship tie = new Ship("Tie", "Fighter", 1);
        Ship wing = new Ship("X-Wing", "Fighter", 3);
        Station rebel = new Station("Rebel Space Station", "Rebel", 15);
        Station deathStar = new Station("Death Star", "Imperial", 100);
        Station cloudCity = new Station("CloudCity", "Imperial", 25);

        falcon.EnterShip(leia, 0);
        falcon.EnterShip(solo, 1);

        Console.WriteLine(luke.FullName);
        cloudCity.dockShip(falcon);
        Console.WriteLine(cloudCity.shipRoster);
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
    public Person[] passengers;
    public string name { get; set; }
    public Ship(string shipName, string type, int size)
    {
        this.Type = type;
        this.name = shipName;
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
    }

    public void ExitShip(int seat)
    {
        this.passengers[seat] = null;
    }
}

class Station
{
    public string shipRoster
    {
        get
        {
            foreach (var ship in ships)
            {
                if (ship != null)
                {
                    Console.WriteLine(String.Format("This is a {0} ship. Here are the passengers:", ship.name));
                    Console.WriteLine(ship.Passengers);
                }
            }

            return "Roster Complete";
        }
    }
    public void dockShip(Ship ship)
    {
        for (int i = 0; i < ships.Length; i++)
        {
            if (ships[i] == null)
            {
                ships[i] = ship;
                break;
            }
        }
    }
    Ship[] ships;
    public string stationName;
    private string alliance;
    private int size;
    public Station(string stationName, string alliance, int size)
    {
        this.stationName = stationName;
        this.alliance = alliance;
        this.size = size;
        this.ships = new Ship[size];
    }
}