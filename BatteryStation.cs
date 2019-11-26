using System;
using System.Collections.Generic;

namespace GenericsExercises
{

    public class BatteryStation : IFuelStation<ElectricVehicles>
    {
        public override void Refuel(List<ElectricVehicles> vehicles)
        {
            foreach (ElectricVehicles vehicle in vehicles)
            {
                vehicle.BatteryLevel = 100;
                Console.WriteLine($"{vehicle.Name} was charged to 100% battery life!");
            }
        }
    }
}