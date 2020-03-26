using Microsoft.VisualStudio.TestTools.UnitTesting;
using CovidApp.Data;
using CovidApp.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CoordsTest()
        {
            Coords coords = CountryCoordinates.countries["US"];

            double expectedLongitude = 1.0;
            double expectedLatitude = 2.0;
            

            Assert.AreEqual(1.0, 1.0, 0.1);
            Assert.AreEqual(expectedLatitude, coords.latitude, 0.1);
            Assert.AreEqual(expectedLongitude, coords.longitude, 0.1);
        }
    }
}
