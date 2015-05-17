using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxiStation.ClassTaxiStation;

namespace TaxiStation
{
    public interface ITuning:ICars
    {
        ListTuning Listtuning { get; }
    }
}
