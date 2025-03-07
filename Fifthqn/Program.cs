using System;
abstract class Vehicle
{
    public abstract void StartEngine();  
    public void StopEngine()  
    {
        Console.WriteLine("Engine stopped.");
    }
}


interface IDriveable
{
    void Drive();  
}

class Car : Vehicle, IDriveable
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }

    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class Bike : Vehicle, IDriveable
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started.");
    }

    public void Drive()
    {
        Console.WriteLine("Bike is driving.");
    }
}

class Program
{
    static void Main()
    {
        Vehicle myCar = new Car();
        myCar.StartEngine();
        myCar.StopEngine();  

        Vehicle myBike = new Bike();
        myBike.StartEngine(); 
        myBike.StopEngine();  

        IDriveable driveCar = new Car();
        driveCar.Drive();  

        IDriveable driveBike = new Bike();
        driveBike.Drive();  
    }
}
