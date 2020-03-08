namespace BerlinClockAPI.UnitTests.Rules
{
    using Domain.Interfaces;
    using Domain.Models;
    using Domain.Models.Rules;
    using NUnit.Framework;

    [TestFixture]
    public class TopSecondsRowRuleTestsTests
    {
        private readonly IRowRule _itemUnderTest;

        public TopSecondsRowRuleTestsTests()
        {
            _itemUnderTest = new TopSecondsRowRowRule();
        }

        [Test]
        public void Given_Specific_Hours_Then_Lamp_Light_Should_Be_Off()
        {
            // Arrange
            var seconds = 51;

            // Act
            var result = _itemUnderTest.Rule(seconds, 1);

            // Assert
            Assert.IsFalse(result.IsSwitchedOn);
            Assert.AreEqual(LampLight.Off, result.Light);
        }

        [Test]
        public void Given_Even_Seconds_Then_Lamp_Light_Should_Be_Yellow()
        {
            // Arrange
            var seconds = 52;

            // Act
            var result = _itemUnderTest.Rule(seconds, 1);

            // Assert
            Assert.AreEqual(LampLight.Yellow, result.Light);
        }
    }
}
