using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            var car = new Car() 
            {
                Year = "2022",
                Make = "Chevy",
                Model = "Camaro",
                HasFourSeats = true,
            };
            var motorcycle = new Motorcycle() 
            { 
                Year = "2023",
                Make = "Kawi",
                Model = "ninja",
                HasTwoWheels = true,
            };

            Vehicle vehicle1 = new Car()
            { Make = "toyota",
                Model = "Gr86",
                Year = "2019"
            };
            Vehicle vehicle2 = new Motorcycle()
            {
                Make = "Honda",
                Model = "r1",
                Year = "2020"
            };
            vehicles.Add(car);
            vehicles.Add(motorcycle);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            car.DriveA();
            car.DriveV();
            motorcycle.DriveA(); 
            motorcycle.DriveV();


            foreach (var vehicle in vehicles) 
            {
             Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");
                if(vehicle is Car c)
                {
                    Console.WriteLine($"has FourSeats{c.HasFourSeats}");
                }
                else if (vehicle is Motorcycle m)
                {
                    Console.WriteLine($"HasTwoWheels {m.HasTwoWheels}");
                    vehicle.DriveA();
                    vehicle.DriveV();
                    Console.WriteLine();
                }
            }

            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
