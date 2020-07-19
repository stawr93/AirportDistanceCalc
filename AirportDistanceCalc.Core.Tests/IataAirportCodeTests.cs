using System;
using NUnit.Framework;

namespace AirportDistanceCalc.Core.Tests
{
    public class IataAirportCodeTests
    {
        [Test]
        public void Should_AllowToCreateInstance_For3LetterString()
        {
            // Arrange
            const string code = "TST";

            // Act
            var instance = new IataAirportCode(code);

            // Assert
            Assert.AreEqual(code, instance.Value, "Should save given code as value");
        }

        [Test]
        public void Should_NotCreateInstance_ForEmptyString()
        {
            Assert.Throws<ArgumentException>(() => new IataAirportCode(string.Empty),
                "Should not create instance for an empty code value");
        }

        [TestCase("A")]
        [TestCase("AA")]
        [TestCase("AAAA")]
        [TestCase("AAAAA")]
        public void Should_CreateInstance_For3LetterStringOnly(string code)
        {
            Assert.Throws<ArgumentException>(() => new IataAirportCode(string.Empty),
                "Should not create instance for code with length more or less than 3");
        }
    }
}