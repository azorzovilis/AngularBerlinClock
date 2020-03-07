using TechTalk.SpecFlow;

namespace BerlinClockAPI.AcceptanceTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Services;
    using Services.Interfaces;

    [Binding]
    public class BerlinClockSteps
    {
        private readonly ITimeConverter _berlinClock;
        private string _theTime;

        /// <summary>
        /// TODO: Add DI
        /// </summary>
        //public BerlinClockSteps(ITimeConverter timeConverter)
        //{
        //    _berlinClock = timeConverter;
        //}

        public BerlinClockSteps()
        {
            _berlinClock = new TimeConverter(new BerlinClockContext(new BerlinClockFactory()), new TimeValidator());
        }

        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            _theTime = time;
        }

        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreEqual(_berlinClock.ConvertTime(_theTime), theExpectedBerlinClockOutput);
        }
    }
}
