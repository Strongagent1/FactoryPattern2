using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
      

        public void Drive()
        {
            Console.WriteLine("The Motorcycle is driving really fast down the road, watch out for them.");
        }

        public void Name()
        {
            Console.WriteLine("Motorcycle building in process....");
        }

        public void NumberOfWheels()
        {
            Console.WriteLine("This is 2 wheeler, better keep your balance!");
        }

        public void WhichLaneToTravelIn()
        {
            Console.WriteLine("This travels in the middle area of the lanes and weaves through traffic it seems, keep an eye out.");
        }
    }
}
