using System;

namespace Tugas2.Models
{
    public class Vehicle
    {
        private string brand;
        private string color;

        public Vehicle(string brand, string color)
        {
            this.brand = brand;
            this.color = color;
        }

        public string Brand => brand;
        public string Color => color;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Kendaraan: {brand}, Warna: {color}");
        }

        public void EngineStart()
        {
            Console.WriteLine($"{brand} dinyalakan.");
        }

        public void EngineStart(string keyType)
        {
            Console.WriteLine($"{brand} dinyalakan dengan {keyType}.");
        }
    }
}