using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            GasVehicles Rav4 = new GasVehicles("Rav4", 14);
            GasVehicles Fusion = new GasVehicles("Fusion", 10);
            GasVehicles Dodge = new GasVehicles("Dodge Ram", 25);

            ElectricVehicles TeslaX = new ElectricVehicles("TeslaX", 43);
            ElectricVehicles Prius = new ElectricVehicles("Prius", 30);
            ElectricVehicles TeslaXL = new ElectricVehicles("TeslaXL", 50);

            List<GasVehicles> listOfGasVehicles = new List<GasVehicles>();
            List<ElectricVehicles> listOfElectricVehicles = new List<ElectricVehicles>();

            listOfElectricVehicles.Add(TeslaX);
            listOfElectricVehicles.Add(Prius);
            listOfElectricVehicles.Add(TeslaXL);
            listOfGasVehicles.Add(Rav4);
            listOfGasVehicles.Add(Fusion);
            listOfGasVehicles.Add(Dodge);

            //Stations
            GasStation gasStation = new GasStation();
            BatteryStation batteryStation = new BatteryStation();

            batteryStation.Refuel(listOfElectricVehicles);
            gasStation.Refuel(listOfGasVehicles);
        }
    }
}