using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Zadaca.MODEL
{
    public class Terminal
    {
        public LargeTrain largeTrain;

        public SmallTrain smallTrain;

        public Employee employee;

        public Terminal()
        {
            largeTrain = new LargeTrain();
            smallTrain = new SmallTrain();
            employee = new Employee();
        }
    }
}
