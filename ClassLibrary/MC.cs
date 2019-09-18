using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class MC:Vehicle
    {

        public override decimal Price(decimal price = 125)
        {

            return price;
        }
        public override string VehicleType(string type = "MC")
        {
            return type;
        }
    }
}
