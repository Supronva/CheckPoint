using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.ClassCarPark
{
    public abstract class Cars : Vehicle,ICars
    {
        public CoutPassengerSeat CoutPassengerSeat { get; set; }
    }
}
