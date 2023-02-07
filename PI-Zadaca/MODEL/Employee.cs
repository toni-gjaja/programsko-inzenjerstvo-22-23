using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PI_Zadaca.MODEL
{
    public class Employee
    {
        public double paycheck = 0.0;

        public const double CUT = 0.1;

        public double GetEmployeeCut()
        {
            return CUT;
        }

        public void ParkCars(SmallTrain smallTrain, List<Car> cars)
        {
            foreach (Car car in cars)
            {
                smallTrain.CarPark(car);
                paycheck = paycheck + car.GetPrice() * CUT;

            }
        }

        public void ParkVans(SmallTrain smallTrain, List<Van> vans)
        {
            foreach (Van van in vans)
            {
                smallTrain.VanPark(van);
                paycheck = paycheck + van.GetPrice() * CUT;
            }
        }

        public void ParkBuses(LargeTrain largeTrain, List<Bus> buses)
        {
            foreach (Bus bus in buses)
            {
                largeTrain.BusPark(bus);
                paycheck = paycheck + bus.GetPrice() * CUT;
            }
        }

        public void ParkTrucks(LargeTrain largeTrain, List<Truck> trucks)
        {
            foreach (Truck truck in trucks)
            {
                largeTrain.TruckPark(truck);
                paycheck = paycheck + truck.GetPrice() * CUT;
            }
        }

        public Car FillCar(Car car)
        {
            if (car.GetGasLevel() < 10)
            {
                car.GasLevel = 100;
            }
            if (car.GetBatteryLevel() < 10)
            {
                car.BatteryLevel = 100;
            }

            return car;
        }

        public Van FillVan(Van van)
        {
            if (van.GetGasLevel() < 10)
            {
                van.GasLevel = 100;
            }
            if (van.GetBatteryLevel() < 10)
            {
                van.BatteryLevel = 100;
            }

            return van;
        }

        public Bus FillBuses(Bus bus)
        {
            if (bus.GetGasLevel() < 10)
            {
                bus.GasLevel = 100;
            }
            if (bus.GetBatteryLevel() < 10)
            {
                bus.BatteryLevel = 100;
            }

            return bus;
        }

        public Truck FillTrucks(Truck truck)
        {
            if (truck.GetGasLevel() < 10)
            {
                truck.GasLevel = 100;
            }
            if (truck.GetBatteryLevel() < 10)
            {
                truck.BatteryLevel = 100;
            }

            return truck;
        }

    }
}
