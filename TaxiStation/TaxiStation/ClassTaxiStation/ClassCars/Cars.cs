using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.ClassTaxiStation
{
    public abstract class Cars : Vehicle,ICars
    {

        public CoutPassengerSeat CoutPassengerSeat { get; set; } //кол-во пассажиров
        
    }
}
