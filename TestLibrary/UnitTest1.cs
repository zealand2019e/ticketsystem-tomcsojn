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
    }
}
