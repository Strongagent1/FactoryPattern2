using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class SemiTruck : IVehicle
    {
     
        public void Drive()
        {
            Console.WriteLine("The Semi is sloooowly starting to roll forward....");
        }

        public void Name()
        {
            Console.WriteLine("Semi tractor trailer build is in process....");
        }

        public void NumberOfWheels()
        {
            Console.WriteLine("Yep, count em, that is 18 glorious wheels on this baby.");
        }

        public void WhichLaneToTravelIn()
        {
            Console.WriteLine("Please help us car drivers out by staying out of the fast lane please.");
        }
    }
}
