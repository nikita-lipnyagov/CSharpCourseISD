using System;
using System.Collections.Generic;

public class Vehicle
{
    public string coordinates = "N48.464717°, E35.046183°";
    public string price;
    public int speed;
    public int yearIssue;

    public virtual void printInfo()
    { }
}

class Plane : Vehicle
{
    public int height;
    public int numPassengers;
    public Plane(){
        this.price = "1 000 000 $";
        this.speed = 855;
        this.yearIssue = 2015;
        this.height = 9876;
        this.numPassengers = 178;
    }
    public override void printInfo(){
        Console.WriteLine("It's a plane!");
        Console.WriteLine("Coordinates: " + coordinates);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Speed: " + speed);
        Console.WriteLine("Year of issue: " + yearIssue);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Number of passangers: " + numPassengers + "\n");
    }
}

class Car : Vehicle
{
    public Car(){
        this.price = "100 000 $";
        this.speed = 280;
        this.yearIssue = 2016;
    }
    public override void printInfo(){
        Console.WriteLine("It's a car!");
        Console.WriteLine("Coordinates: " + coordinates);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Speed: " + speed);
        Console.WriteLine("Year of issue: " + yearIssue + "\n");
    }
}

class Ship : Vehicle
{
    public int port;
    public int numPassengers; 
    public Ship(){
        this.price = "1 000 000 $";
        this.speed = 855;
        this.yearIssue = 2015;
        this.port = 123;
        this.numPassengers = 593;
    }
    public override void printInfo(){
        Console.WriteLine("It's a ship!");
        Console.WriteLine("Coordinates: " + coordinates);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Speed: " + speed);
        Console.WriteLine("Year of issue: " + yearIssue);
        Console.WriteLine("Number of passangers: " + numPassengers);
        Console.WriteLine("Home port: " + port + "\n");
    }
}
    

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {  
            Vehicle Boing = new Plane();
            Boing.printInfo();

            Vehicle BMW = new Car();
            BMW.printInfo();

            Vehicle Maria = new Ship();
            Maria.printInfo();

            Console.ReadKey();
        }
    }
}
