using System;
using System.Collections.Generic;
using Tugas2.Models;

namespace Tugas2.Services
{
    public class Garage
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void ShowVehicles()
        {
            Console.WriteLine("Daftar Kendaraan di Garage:");
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
            }
        }
    }
}
