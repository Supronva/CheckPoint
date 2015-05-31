using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarPark.ClassCarPark;

namespace CarPark
{
    public interface ITuning:ICars
    {
        ListTuning Listtuning { get; }
    }
}
