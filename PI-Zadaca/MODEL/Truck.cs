using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Zadaca.MODEL
{
    public class Truck : Vehicle
    {
        public int GasLevel { get; set; }

        public int BatteryLevel { get; set; }

        const int PRICE = 90;

        public Truck(int gasLevel, int batteryLevel)

        {
            GasLevel = gasLevel;
            BatteryLevel = batteryLevel;
        }

        public override int GetBatteryLevel()
        {
            return BatteryLevel;
        }

        public override int GetGasLevel()
        {
            return GasLevel;
        }

        public override int GetPrice()
        {
            return PRICE;
        }
    }
}
