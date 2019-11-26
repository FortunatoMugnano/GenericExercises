using System;
using System.Collections.Generic;

namespace GenericsExercises
{

    public class GasStation : IFuelStation<GasVehicles>
    {
        public override void Refuel(List<GasVehicles> vehicles)
        {
            foreach (GasVehicles vehicle in vehicles)
            {
                vehicle.FuelLevel = 100;
                Console.WriteLine($"{vehicle.Name} was fueled to 100%!");
            }
        }
    }
}