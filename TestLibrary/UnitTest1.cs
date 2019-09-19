using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;
using System;


namespace TestLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_Price()
        {
           
            Car c = new Car();
            double result = c.Price();
            Assert.AreEqual(result, 240);
        }
        [TestMethod]
        public void test_Type()
        {
            Car c = new Car();
            string result = c.VehicleType();
            Assert.AreEqual(result, "Car");
        }
        [TestMethod]
        public void test_Price_mc()
        {

            MC c = new MC();
            double result = c.Price();
            Assert.AreEqual(result, 125);
        }
        [TestMethod]
        public void test_Type_mc()
        {
            MC c = new MC();
            string result = c.VehicleType();
            Assert.AreEqual(result, "MC");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void test_exception_mc()
        {
            MC c = new MC();
            c.Licensplate = "ABC123ABC";
            Assert.Fail();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void test_exception_car()
        {
            Car c = new Car();
            c.Licensplate = "ABC123ABC";
            Assert.Fail();
        }
        [TestMethod]
        public void test_discount_mc()
        {
            MC c = new MC();
            c.brobizz = true;
            double result = c.Price();
            Assert.AreEqual(result,118.75);
            
        }
        [TestMethod]
        public void test_discount_car()
        {
            Car c = new Car();
            c.brobizz = true;
            double result = c.Price();
            Assert.AreEqual(result, 228);
            
        }
        [TestMethod]
        public void test_weekend_discount_car()
        {
            StoreBaeltTicketLibrary.Car c = new StoreBaeltTicketLibrary.Car();
            c.brobizz = true;
            c.Date = new DateTime(2019,09,21);

            double result = c.Price();
            Assert.AreEqual(result,182.4,0.01);

        }
        [TestMethod]
        public void test_oresund_Price()
        {

            OresundBron.Car c = new OresundBron.Car();
            double result = c.Price();
            Assert.AreEqual(result, 410);
        }
        [TestMethod]
        public void test_oresund_discount_Price()
        {

            OresundBron.Car c = new OresundBron.Car();
            c.brobizz = true;

            double result = c.Price();
            Assert.AreEqual(result, 161);
        }
        [TestMethod]
        public void test_oresund_Type()
        {
            OresundBron.Car c = new OresundBron.Car();
            string result = c.VehicleType();
            Assert.AreEqual(result, "Oresund car");
        }
        [TestMethod]
        public void test_oresund_Price_mc()
        {

            OresundBron.MC c = new OresundBron.MC();
            double result = c.Price();
            Assert.AreEqual(result, 210);
        }
        [TestMethod]
        public void test_oresund_discount_Price_mc()
        {

            OresundBron.MC c = new OresundBron.MC();
            c.brobizz = true;

            double result = c.Price();
            Assert.AreEqual(result, 73);
        }
        [TestMethod]
        public void test_oresund_Type_mc()
        {
            OresundBron.MC c = new OresundBron.MC();
            string result = c.VehicleType();
            Assert.AreEqual(result, "Oresund MC");
        }


    }
}
