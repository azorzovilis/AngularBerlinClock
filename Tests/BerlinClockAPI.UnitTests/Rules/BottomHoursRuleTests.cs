namespace BerlinClockAPI.UnitTests.Rules
{
    using Domain.Interfaces;
    using Domain.Models;
    using Domain.Models.Rules;
    using NUnit.Framework;

    [TestFixture]
    public class BottomHoursRuleTests
    {
        private readonly IRowRule _itemUnderTest;

        public BottomHoursRuleTests()
        {
            _itemUnderTest = new BottomHoursRowRule();
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(5, 0)]
        [TestCase(10, 0)]
        [TestCase(15, 0)]
        [TestCase(20, 0)]
        [TestCase(0, 1)]
        [TestCase(5, 1)]
        [TestCase(10, 1)]
        [TestCase(15, 1)]
        [TestCase(20, 1)]
        [TestCase(0, 2)]
        [TestCase(5, 2)]
        [TestCase(10, 2)]
        [TestCase(15, 2)]
        [TestCase(20, 2)]
        [TestCase(0, 3)]
        [TestCase(5, 3)]
        [TestCase(10, 3)]
        [TestCase(15, 3)]
        [TestCase(20, 3)]
        //TODO: Add missing test cases
        public void Given_Specific_Hours_And_Lamp_Index_Then_Lamp_Light_Should_Be_Off(int hours, int lampIndex)
        {
            // Act
            var result = _itemUnderTest.Rule(hours, lampIndex);

            // Assert
            Assert.IsFalse(result.IsSwitchedOn);
            Assert.AreEqual(LampLight.Off, result.Light);
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(3, 0)]
        [TestCase(4, 0)]
        [TestCase(6, 0)]
        [TestCase(7, 0)]
        [TestCase(8, 0)]
        [TestCase(9, 0)]
        [TestCase(11, 0)]
        [TestCase(12, 0)]
        [TestCase(13, 0)]
        [TestCase(14, 0)]
        [TestCase(16, 0)]
        [TestCase(17, 0)]
        [TestCase(18, 0)]
        [TestCase(19, 0)]
        [TestCase(21, 0)]
        [TestCase(22, 0)]
        [TestCase(23, 0)]
        [TestCase(24, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 1)]
        [TestCase(7, 1)]
        [TestCase(8, 1)]
        [TestCase(9, 1)]
        [TestCase(12, 1)]
        [TestCase(13, 1)]
        [TestCase(14, 1)]
        [TestCase(17, 1)]
        [TestCase(18, 1)]
        [TestCase(19, 1)]
        [TestCase(22, 1)]
        [TestCase(23, 1)]
        [TestCase(24, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 2)]
        [TestCase(8, 2)]
        [TestCase(9, 2)]
        [TestCase(13, 2)]
        [TestCase(14, 2)]
        [TestCase(18, 2)]
        [TestCase(19, 2)]
        [TestCase(23, 2)]
        [TestCase(24, 2)]
        [TestCase(4, 3)]
        [TestCase(9, 3)]
        [TestCase(14, 3)]
        [TestCase(19, 3)]
        [TestCase(24, 3)]
        public void Given_Specific_Hours_And_Lamp_Index_Then_Lamp_Light_Should_Be_Red(int hours, int lampIndex)
        {
            // Act
            var result = _itemUnderTest.Rule(hours, lampIndex);

            // Assert
            Assert.AreEqual(LampLight.Red, result.Light);
        }
    }
}
