using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
       

        public void Drive()
        {
            Console.WriteLine("The Car is driving down the road.");
        }

        public void Name()
        {
            Console.WriteLine("Car building in process....");
        }

        public void NumberOfWheels()
        {
            Console.WriteLine("The car has just the normal 4 wheels to get from point A to point B.");
        }

        public void WhichLaneToTravelIn()
        {
            Console.WriteLine("Move out of the fast lane if you must drive your car at semi-truck speed or build your own 18 wheeler to drive!");
        }
    }
}
