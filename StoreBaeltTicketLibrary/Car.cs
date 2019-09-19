using System;
using TicketLibrary;

namespace StoreBaeltTicketLibrary
{
    public class Car:TicketLibrary.Car
    {
        public double Price()
        {
            double price = 240;
            DayOfWeek day = this.Date.DayOfWeek;
            if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                price *= 0.8;
            }
            return base.Price(price);
        }
    }
    
}
