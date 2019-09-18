using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
  public   class Vehicle
    {
        string licensplate;
        public string Licensplate {
            get {return licensplate; }
            set {
                if (value.Length > 7) throw new ArgumentOutOfRangeException();
                else licensplate = value; } }
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
