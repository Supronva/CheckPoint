using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPark
{
    public interface IConvertibleTop : ITuning
    {
        bool ConvertibleTop { get;}
    }
}
