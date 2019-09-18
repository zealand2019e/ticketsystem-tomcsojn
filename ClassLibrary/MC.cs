using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class MC:Vehicle
    {

        public override double Price(double price = 125)
        {
            return base.Price(price);
            
        }
        public override string VehicleType(string type = "MC")
        {
            return type;
        }
    }
}
