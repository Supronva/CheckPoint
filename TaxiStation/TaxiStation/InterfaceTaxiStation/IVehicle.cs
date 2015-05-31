using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.ClassTaxiStation;

namespace TaxiStation.InterfaceTaxiStation
{
    public interface IVehicle
    {
        MarkaVehicle MarkaVehicler { get; }
        string Name { get; }
        int PriceCar { get; }
        int SpeedCar { get; }
        int ExpenseFuel { get; }
        TypeFuel TypeFuel { get; }
        double VEngine { get; }
    }
}
