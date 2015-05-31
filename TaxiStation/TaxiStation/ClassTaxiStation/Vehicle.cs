using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.InterfaceTaxiStation;

namespace TaxiStation.ClassTaxiStation
{
    public abstract class Vehicle : IVehicle
    {


        public MarkaVehicle MarkaVehicler { get; set; }

        public string Name { get; set; }

        public int PriceCar { get; set; }

        public int SpeedCar { get; set; }

        public int ExpenseFuel { get; set; }

        public double VEngine { get; set; }

        public TypeFuel TypeFuel { get; set; }
        
    }
}
