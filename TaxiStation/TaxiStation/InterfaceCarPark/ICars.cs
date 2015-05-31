using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarPark.ClassCarPark;
using CarPark.InterfaceCarPark;

namespace CarPark
{
    public interface ICars: IVehicle
    {
      CoutPassengerSeat CoutPassengerSeat { get; }
    }
}
