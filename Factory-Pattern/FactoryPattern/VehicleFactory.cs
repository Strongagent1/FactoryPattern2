using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle()
        {
            Console.WriteLine("How many wheels would you like on your new vehicle?");
            var userResponse = int.Parse(Console.ReadLine());

                switch (userResponse)
                {
                    case 2:
                        return new Motorcycle();
                    case 4:
                        return new Car();
                    case 18:
                        return new SemiTruck();
                    default:
                        return new Motorcycle();
                   
                        

                }
                       
        }
               
    }
}
