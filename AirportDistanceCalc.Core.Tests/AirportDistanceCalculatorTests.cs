using System.Threading.Tasks;
using Geolocation;
using Moq;
using NUnit.Framework;

namespace AirportDistanceCalc.Core.Tests
{
    [TestFixture]
    public class AirportDistanceCalculatorTests
    {
        private AirportDistanceCalculator _calculator;
        private Mock<IAirportLocationProvider> _locationProviderMock;

        [SetUp]
        public void Setup()
        {
            _locationProviderMock = new Mock<IAirportLocationProvider>();
            _calculator = new AirportDistanceCalculator(_locationProviderMock.Object);
        }

        [Test]
        public async Task Should_CalculateDistance()
        {
            // Arrange
            var orig = new IataAirportCode("ORG");
            var dest = new IataAirportCode("DST");
            var origCoordinate = new Coordinate(0,0);
            var destCoordinate = new Coordinate(0,1);

            _locationProviderMock.Setup(_ => _.LocationOf(orig)).Returns(Task.FromResult(origCoordinate));
            _locationProviderMock.Setup(_ => _.LocationOf(dest)).Returns(Task.FromResult(destCoordinate));

            // Act
            var result = await _calculator.DistanceBetween(orig, dest);

            // Assert
            Assert.AreEqual(111.2d, result);
        }
    }
}