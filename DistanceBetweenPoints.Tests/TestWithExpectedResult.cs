using DistanceBetweenPoints.Services.Interfaces;
using DistanceBetweenPoints.Services.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DistanceBetweenPoints.Tests
{
    [TestClass]
    public class TestWithExpectedResult
    {
        [TestMethod]
        public void CorrectData_CorrectResult1()
        {
            //Arange

            double expected = 5536.338682266685;
            var input = new DistanceInputModel()
            {
                Lat1 = 53.297975,
                Long1 = -6.372663,
                Lat2 = 41.385101,
                Long2 = -81.440440
            };

            var serviceMock = new Mock<IDistanceService>();
            serviceMock
                .Setup(x => x.CalculateDistance(input))
                .Returns(expected);

            var sut = new DistanceObj(serviceMock.Object, input);

            //Act
            var actual = sut.CalculateDistance();

            //Asert
            Assert.AreEqual(expected, actual, 0.001, "Expected and actual values do not match");
        }

        [TestMethod]
        public void CorrectData_CorrectResult2()
        {
            //Arange

            double expected = 5574.840456848555;
            var input = new DistanceInputModel()
            {
                Lat1 = 51.5007,
                Long1 = -0.1246,
                Lat2 = 40.6892,
                Long2 = -74.0445
            };

            var serviceMock = new Mock<IDistanceService>();
            serviceMock
                .Setup(x => x.CalculateDistance(input))
                .Returns(5574.840456848555);

            var sut = new DistanceObj(serviceMock.Object, input);

            //Act
            var actual = sut.CalculateDistance();

            //Asert
            Assert.AreEqual(expected, actual, 0.001, "Expected and actual values do not match");
        }
    }
}