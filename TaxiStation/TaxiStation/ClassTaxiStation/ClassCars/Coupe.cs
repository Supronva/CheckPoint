﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxiStation.ClassTaxiStation
{
    public class Coupe:Cars,IConvertibleTop
    {

        public bool ConvertibleTop { get; set; }

        public ListTuning Listtuning { get; set; }
       
    }
}
