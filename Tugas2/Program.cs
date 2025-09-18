using System;
using Tugas2.Models;
using Tugas2.Services;

namespace Tugas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();

            Vehicle car = new Car("Toyota", "Red", 4);
            Vehicle motorcycle = new Motorcycle("Yamaha", "Blue", false);

            garage.AddVehicle(car);
            garage.AddVehicle(motorcycle);

            garage.ShowVehicles();

            car.EngineStart();
            motorcycle.EngineStart("remote");
        }
    }
}