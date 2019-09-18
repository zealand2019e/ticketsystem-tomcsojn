using System;

namespace TicketLibrary
{
    public class Car:Vehicle
    {/// <summary>
    /// Car Class with Price, and VehicleType
    /// </summary>
        public override decimal Price(decimal price = 240)
        {
           
            return price;
        }
        public override string VehicleType(string type = "Car")
        {
            return type;
        }
    }
}
