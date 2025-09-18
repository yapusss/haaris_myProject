using System;

namespace Tugas2.Models
{
    public class  Car : Vehicle
    {
        public int Doors { get; set; }

        public Car(string brand, string color, int doors) : base(brand, color)
        {
            Doors = doors;
        }

        //override
        public override void DisplayInfo()
        {
            Console.WriteLine($"Kendaraan: {Brand}, Warna: {Color}, Pintu: {Doors}");
        }
    }
}