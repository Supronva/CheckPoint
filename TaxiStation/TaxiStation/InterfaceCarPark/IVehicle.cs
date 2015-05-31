using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPark.ClassCarPark;

namespace CarPark.InterfaceCarPark
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
