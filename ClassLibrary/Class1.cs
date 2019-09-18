using System;

namespace TicketLibrary
{
    public class Car
    {/// <summary>
    /// Car Class with Price, and VehicleType
    /// </summary>
        public string Licensplate;
        public DateTime Date;
        public decimal Price(decimal price = 240)
        {
           
            return price;
        }
        public string VehicleType(string type = "Car")
        {
            return type;
        }
    }
}
