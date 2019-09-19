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
        public double Price()
        {
            return base.Price(125);
            
        }
        public override string VehicleType(string type = "MC")
        {
            return type;
        }
    }
}
