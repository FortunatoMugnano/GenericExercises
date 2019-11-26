using System;
using System.Collections.Generic;

namespace GenericsExercises
{
    public class ElectricVehicles
    {
        public int BatterykWh { get; set; }

        public string Name { get; set; }

        public int BatteryLevel { get; set; }

        public List<ElectricVehicles> allElectricVehicles = new List<ElectricVehicles>();

        public ElectricVehicles(string name, int batteryLevel)
        {
            Name = name;
            BatteryLevel = batteryLevel;
        }

        public void ChargeBattery()
        {
            BatterykWh = 100;
        }

        public void Drive()
        {
            Console.WriteLine("Vroom!");
        }
    }
}