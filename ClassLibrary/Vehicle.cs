using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
  public abstract class Vehicle
    {
        /// <summary>
        /// 
        /// </summary>
        string licensplate;
        public string Licensplate {
            get {return licensplate; }
            set {
                if (value.Length > 7) throw new ArgumentOutOfRangeException();
                else licensplate = value; } }
        public DateTime Date;
        public bool brobizz;
        public virtual double Price(double price = 240)
        {
            if (brobizz)
            {
                return price*0.95;
            }
            return price;
        }
        public virtual string VehicleType(string type = "Car")
        {
            return type;
        }
    }
}
