using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPark.ClassCarPark
{
    public class SportsCar : Cars, ITuning
    {
        public ListTuning Listtuning { get; set; }
    }
}
