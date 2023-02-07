using PI_Zadaca.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Zadaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            
            cars.Add(new Car(5, 5));
            cars.Add(new Car(40, 5));
            cars.Add(new Car(6, 60));
            cars.Add(new Car(15, 50));

            List<Van> vans = new List<Van>();

            vans.Add(new Van(4, 4));
            vans.Add(new Van(12, 5));
            vans.Add(new Van(50, 50));
            vans.Add(new Van(2, 60));

            List<Bus> buses = new List<Bus>();

            buses.Add(new Bus(7, 7));
            buses.Add(new Bus(40, 40));
            buses.Add(new Bus(20, 5));

            List<Truck> trucks = new List<Truck>();

            trucks.Add(new Truck(30, 3));
            trucks.Add(new Truck(50, 40));
            trucks.Add(new Truck(70, 50));

            Terminal terminal = new Terminal();

            terminal.employee.ParkCars(terminal.smallTrain, cars);
            terminal.employee.ParkVans(terminal.smallTrain, vans);

            terminal.employee.ParkBuses(terminal.largeTrain, buses);
            terminal.employee.ParkTrucks(terminal.largeTrain, trucks);

            Console.WriteLine("Employee paycheck: " + terminal.employee.paycheck);

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Vehicle status upon arrival");

            Console.WriteLine("");

            Console.WriteLine("Cars");

            Console.WriteLine("");

            foreach (Car car in cars)
            {
                Console.WriteLine("Gas level: " + car.GetGasLevel() + "," + "Battery level: " + car.GetBatteryLevel());
            }

            Console.WriteLine("");

            Console.WriteLine("Vans");

            Console.WriteLine("");

            foreach (Van van in vans)
            {
                Console.WriteLine("Gas level: " + van.GetGasLevel() + "," + "Battery level: " + van.GetBatteryLevel());
            }

            Console.WriteLine("");

            Console.WriteLine("Buses");

            Console.WriteLine("");

            foreach (Bus bus in buses)
            {
                Console.WriteLine("Gas level: " + bus.GetGasLevel() + "," + "Battery level: " + bus.GetBatteryLevel());
            }

            Console.WriteLine("");

            Console.WriteLine("Trucks");

            Console.WriteLine("");

            foreach (Truck truck in trucks)
            {
                Console.WriteLine("Gas level: " + truck.GetGasLevel() + "," + "Battery level: " + truck.GetBatteryLevel());
            }

            Console.WriteLine("-------------------------------------------------------------------------------------");

            Console.WriteLine("Vehicles after check-up");

            Console.WriteLine("");

            Console.WriteLine("Cars");

            Console.WriteLine("");

            foreach (Car car in terminal.smallTrain.Cars)
            {
                terminal.employee.FillCar(car);
                Console.WriteLine("Gas level: " + car.GetGasLevel() + "," + "Battery level: " + car.GetBatteryLevel());
            }

            Console.WriteLine("");

            Console.WriteLine("Vans");

            Console.WriteLine("");

            foreach (Van van in terminal.smallTrain.Vans)
            {
                terminal.employee.FillVan(van);
                Console.WriteLine("Gas level: " + van.GetGasLevel() + "," + "Battery level: " + van.GetBatteryLevel());
            }

            Console.WriteLine("");

            Console.WriteLine("Buses");

            Console.WriteLine("");

            foreach (Bus bus in terminal.largeTrain.Buses)
            {
                terminal.employee.FillBuses(bus);
                Console.WriteLine("Gas level: " + bus.GetGasLevel() + "," + "Battery level: " + bus.GetBatteryLevel());
            }

            Console.WriteLine("");

            Console.WriteLine("Trucks");

            Console.WriteLine("");

            foreach (Truck truck in terminal.largeTrain.Trucks)
            {
                terminal.employee.FillTrucks(truck);
                Console.WriteLine("Gas level: " + truck.GetGasLevel() + "," + "Battery level: " + truck.GetBatteryLevel());
            }

            Console.WriteLine("-------------------------------------------------------------------------------------");

            Console.WriteLine("Testing");

            Console.WriteLine("");

            UnitTest unitTest = new UnitTest();
            unitTest.StartTest();


        }

      
    }
}
