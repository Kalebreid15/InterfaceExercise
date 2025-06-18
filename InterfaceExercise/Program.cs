using ConsoleUI;
using InterfaceExercise;
using System;
using System.Collections.Generic;

Car myFirstCar = new Car
{
    Year = "2020",
    Make = "Toyota",
    Model = "Camry",
    HasTrunk = true
};
SUV myFirstSUV = new SUV
{
    Year = "2021",
    Make = "Honda",
    Model = "CR-V",
    HasExtraWheelOnBack = false
};
Truck myFirstTruck = new Truck
{
    Year = "2019",
    Make = "Ford",
    Model = "F-150",
    HasFlatBed = true
};

List<ICompany> vehicles = new List<ICompany>();

vehicles.Add(myFirstCar);
vehicles.Add(myFirstSUV);
vehicles.Add(myFirstTruck);

foreach (IVehicle vehicle in vehicles)
{
    Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");
    Console.WriteLine();
    vehicle.Drive();
    Console.WriteLine();

}

Console.ReadLine();


