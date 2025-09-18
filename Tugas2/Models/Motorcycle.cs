using System;

namespace Tugas2.Models
{
    public class Motorcycle : Vehicle
    {
        public bool HasGear { get; set; }

        public Motorcycle(string brand, string color, bool hasGear) : base(brand, color)
        {
            HasGear = hasGear;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Kendaraan: {Brand}, Warna: {Color}, {(HasGear ? "dengan gigi" : "tanpa gigi")}");
        }
    }
}
