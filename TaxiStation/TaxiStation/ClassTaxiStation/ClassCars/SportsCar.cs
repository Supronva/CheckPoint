using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxiStation.ClassTaxiStation
{
    public class SportsCar : Cars, ITuning
    {

        public ListTuning Listtuning { get; set; }//тюниг
       
        
    }
}
