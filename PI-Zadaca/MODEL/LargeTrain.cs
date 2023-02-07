using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Zadaca.MODEL
{
    public class LargeTrain
    {
        public List<Bus> Buses { get; set; }

        public List<Truck> Trucks { get; set; }

        public LargeTrain()
        {
            Buses = new List<Bus>();
            Trucks = new List<Truck>();
        }

        public void BusPark(Bus bus)
        {
            Buses.Add(bus);
        }

        public void TruckPark(Truck truck)
        {
            Trucks.Add(truck);
        }

        public LargeTrain ShallowCopy()
        {
            return (LargeTrain)MemberwiseClone();
        }
    }
}
