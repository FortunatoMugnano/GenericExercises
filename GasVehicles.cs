using System;

namespace GenericsExercises
{
    public class GasVehicles
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }

        public string Name { get; set; }

        public GasVehicles(string name, int fuelCapacity)
        {
            Name = name;
            FuelCapacity = fuelCapacity;
        }

        public void Drive()
        {
            Console.WriteLine("Roooooooar!");
        }

        public void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }
    }
}