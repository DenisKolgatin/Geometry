using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCircle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestC() //Тест площади круга
        {
            //arrange
            double a = 4;
            double exp = 50.24;

            //act
            double result = GeoLib.GeoLibClass.Circle(a);
            // assert            
            Assert.AreEqual(exp, result);
        }
    }
}
