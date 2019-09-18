using System;

namespace TicketLibrary
{
    public class Car:Vehicle
    {/// <summary>
    /// Car Class with Price, and VehicleType
    /// </summary>
        public override double Price(double price = 240)
        {
           
            return base.Price(price);
        }
        public override string VehicleType(string type = "Car")
        {
            return type;
        }
    }
}
