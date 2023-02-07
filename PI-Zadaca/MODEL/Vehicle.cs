using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Zadaca.MODEL
{
    public abstract class Vehicle
    {
        public abstract int GetGasLevel();

        public abstract int GetBatteryLevel();

        public abstract int GetPrice();
    }
}
