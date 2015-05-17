using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.InterfaceTaxiStation;

namespace TaxiStation.ClassTaxiStation
{
    class VehicleComparerByExpenseFuel :IComparer<IVehicle>
    {
        public int Compare(IVehicle x, IVehicle y)
        {

            if (x != null && y != null)
            {
                if (x.ExpenseFuel > y.ExpenseFuel)
                {
                    return 1;
                }
                else
                {
                    return (x.ExpenseFuel == y.ExpenseFuel) ? 0 : -1;
                }
            }
            else
            {
                return (y == null && x == null) ? 0 : (x != null) ? 1 : -1;
            }
        }
    }
}
