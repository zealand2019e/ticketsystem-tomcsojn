using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;

namespace TestLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_Price()
        {
           
            Car c = new Car();
            decimal result = c.Price();
            Assert.AreEqual(result, 240);
        }
        [TestMethod]
        public void test_Type()
        {
            Car c = new Car();
            string result = c.VehicleType();
            Assert.AreEqual(result, "Car");
        }
    }
}
