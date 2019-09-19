using System;

namespace OresundBron
{
    public class Car:TicketLibrary.Car
    {
        public double Price()
        {
            double price = 410;
            if (brobizz)
            {
                return 161;
            }
            return price;
        }
        public string VehicleType()
        {
            string type = "Oresund car";
            return type;
        }
    }
}
