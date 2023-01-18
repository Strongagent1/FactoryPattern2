﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IVehicle
    {
        public void Drive();
        public void Name();
      
        public void NumberOfWheels();
        public void WhichLaneToTravelIn();
    }
}
