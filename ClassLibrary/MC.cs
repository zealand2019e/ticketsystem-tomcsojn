using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class MC:Vehicle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
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
