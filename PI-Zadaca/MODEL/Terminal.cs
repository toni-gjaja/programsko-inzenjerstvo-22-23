using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Zadaca.MODEL
{
    public class Terminal : TerminalOpener
    {
        public LargeTrain largeTrain;

        public SmallTrain smallTrain;

        public Employee employee;

        public string openState = "Closed";

        public Terminal()
        {
            largeTrain = new LargeTrain();
            smallTrain = new SmallTrain();
            employee = new Employee();
        }

        public Terminal ShallowCopy()
        {
            return(Terminal)MemberwiseClone();
        }

        public Terminal DeepCopy()
        {
            Terminal terminalClone = ShallowCopy();
            terminalClone.largeTrain = largeTrain;
            terminalClone.smallTrain = smallTrain;
            terminalClone.employee = employee;
            return terminalClone;
        }

        public override void OpenTerminal()
        {
            openState = "Opened";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Terminal is now opened");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
