using System;

namespace TicketLibrary
{
    public class Car:Vehicle
    {/// <summary>
    /// Car Class with Price, and VehicleType
    /// </summary>
        public double Price()
        {
           
            return base.Price(240);
        }
        public override string VehicleType(string type = "Car")
        {
            return type;
        }
    }
}
