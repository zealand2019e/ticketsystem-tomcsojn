using System;
using System.Collections.Generic;
using System.Text;

namespace OresundBron
{
    public class MC:TicketLibrary.MC
    {
        public double Price()
        {
            double price = 210;
            if (brobizz)
            {
                return 73;
            }
            return price;
        }
        public string VehicleType()
        {
            string type = "Oresund MC";
            return type;
        }
    }
}
