using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PI_Zadaca.MODEL
{
    public class UnitTest
    {
        public void StartTest()
        {

            Employee employee = new Employee();
            NUnit.Framework.Assert.IsNotNull(employee);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test 1 passed (Employee object initialization)");
            Console.ForegroundColor = ConsoleColor.White;

            System.Threading.Thread.Sleep(1000);

            NUnit.Framework.Assert.AreEqual(employee.GetEmployeeCut(), 0.1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test 2 passed (Employee method test)");
            Console.ForegroundColor = ConsoleColor.White;

            System.Threading.Thread.Sleep(1000);

            Car car = new Car(50, 50);
            NUnit.Framework.Assert.IsNotNull(car);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test 3 passed (Car object initialization)");
            Console.ForegroundColor = ConsoleColor.White;

            System.Threading.Thread.Sleep(1000);

            NUnit.Framework.Assert.AreEqual(car.GetGasLevel(), 50);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test 4 passed (Car method test)");
            Console.ForegroundColor = ConsoleColor.White;

            System.Threading.Thread.Sleep(1000);

            NUnit.Framework.Assert.AreEqual(car.GetBatteryLevel(), 50);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test 5 passed (Car method test)");
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
