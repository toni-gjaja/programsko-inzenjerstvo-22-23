using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Zadaca.MODEL
{
    public class SmallTrain
    {

        public List<Car> Cars { get; set; }

        public List<Van> Vans { get; set; }

        public SmallTrain()
        {
            Cars = new List<Car>();
            Vans = new List<Van>();
        }

        public void CarPark(Car car)
        {
            Cars.Add(car);
        }

        public void VanPark(Van van)
        {
            Vans.Add(van);
        }

        public SmallTrain ShallowCopy()
        {
            return (SmallTrain)MemberwiseClone();
        }

    }
}
