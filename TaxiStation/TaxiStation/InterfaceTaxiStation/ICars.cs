using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxiStation.ClassTaxiStation;
using TaxiStation.InterfaceTaxiStation;

namespace TaxiStation
{
    public interface ICars: IVehicle
    {
      CoutPassengerSeat CoutPassengerSeat { get; }
    }
}
