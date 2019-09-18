using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
  public   class Vehicle
    {
        public string Licensplate;
        public DateTime Date;
        public virtual decimal Price(decimal price = 240)
        {

            return price;
        }
        public virtual string VehicleType(string type = "Car")
        {
            return type;
        }
    }
}
