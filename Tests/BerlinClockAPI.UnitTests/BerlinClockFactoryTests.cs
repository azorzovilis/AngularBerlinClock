﻿namespace BerlinClockAPI.UnitTests
{
    using System;
    using NUnit.Framework;
    using Services;
    using Services.Interfaces;

    [TestFixture]
    public class BerlinClockFactoryTests
    {
        private readonly IBerlinClockFactory _itemUnderTest;

        public BerlinClockFactoryTests()
        {
            _itemUnderTest = new BerlinClockFactory();
        }

        [Test]
        public void Given_Zero_TimeSpan_Then_A_Clock_Having_Midnight_Time_Should_Be_Returned()
        { 
            // Arrange
            var aTime = new TimeSpan(0, 0, 0);
            var expectedClockStr =
                "Y" + Environment.NewLine
                + "OOOO" + Environment.NewLine
                + "OOOO" + Environment.NewLine
                + "OOOOOOOOOOO" + Environment.NewLine
                + "OOOO";

            // Act
            var result = _itemUnderTest.GenerateBerlinClock(aTime);

            // Assert
            Assert.AreEqual(expectedClockStr, result.ToString());
            Assert.AreEqual(aTime.ToString("hh\\:mm\\:ss"), result.UtcTime);
        }

        [Test]
        public void Given_24h_TimeSpan_Then_A_Clock_Having_Midnight_Time_Should_Be_Returned()
        {
            // Arrange
            var aTime = new TimeSpan(1, 0, 0, 0);
            var expectedClockStr =
                "Y" + Environment.NewLine
                + "RRRR" + Environment.NewLine
                + "RRRR" + Environment.NewLine
                + "OOOOOOOOOOO" + Environment.NewLine
                + "OOOO";

            // Act
            var result = _itemUnderTest.GenerateBerlinClock(aTime);

            // Assert
            Assert.AreEqual(expectedClockStr, result.ToString());
            Assert.AreEqual(aTime.ToString("hh\\:mm\\:ss"), result.UtcTime);
        }

        [Test]
        public void Given_A_Valid_TimeSpan_Then_A_Clock_With_Berlin_Time_Should_Be_Returned()
        {
            // Arrange
            var aTime = new TimeSpan(17, 56, 32);
            var expectedClockStr =
                "Y" + Environment.NewLine
                + "RRRO" + Environment.NewLine
                + "RROO" + Environment.NewLine
                + "YYRYYRYYRYY" + Environment.NewLine
                + "YOOO";

            // Act
            var result = _itemUnderTest.GenerateBerlinClock(aTime);

            // Assert
            Assert.AreEqual(expectedClockStr, result.ToString());
            Assert.AreEqual(aTime.ToString("hh\\:mm\\:ss"), result.UtcTime);
        }
    }
}
