using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTreug
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() //Тест площади треугольника
        {
            //arrange
            double a = 4;
            double b = 5;
            double c = 3;
            double exp = 6;

            //act
            double result = GeoLib.GeoLibClass.Triangle(a, b, c);
            // assert            
            Assert.AreEqual(exp, result);
        }
    }
}
