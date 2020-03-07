namespace BerlinClockAPI.UnitTests
{
    using NUnit.Framework;
    using Services;
    using Services.Interfaces;

    [TestFixture]
    public class TimeValidatorTests
    {
        private readonly ITimeValidator _itemUnderTest;

        public TimeValidatorTests()
        {
            _itemUnderTest = new TimeValidator();
        }

        [Test]
        public void Given_Invalid_Input_Then_Result_Should_Return_False()
        {
            // Arrange
            var aTime = "11:00";

            // Act
            var result = _itemUnderTest.IsValidTime(aTime);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Given_More_Than_24_Hours_Then_Result_Should_Return_False()
        {
            // Arrange
            var aTime = "25:00:00";

            // Act
            var result = _itemUnderTest.IsValidTime(aTime);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Given_Valid_Input_Then_Validation_Should_Return_True()
        {
            // Arrange
            var aTime = "21:52:14";

            // Act
            var result = _itemUnderTest.IsValidTime(aTime);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
