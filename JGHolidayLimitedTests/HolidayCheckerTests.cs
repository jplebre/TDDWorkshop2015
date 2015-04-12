using NUnit.Framework;
using Rhino.Mocks;
using JGHolidayLimited;
using System;

namespace JGHolidayLimitedTests
{
    [TestFixture()]
    public class HolidayCheckerTests
    {
        int week = 26;
        int year = 2015;
        IFlightChecker stubFlightChecker;
        IVillaChecker stubVillaChecker;

        [SetUp()]
        public void TestSetup()
        {
            stubFlightChecker = MockRepository.GenerateStub<IFlightChecker>();
            stubVillaChecker = MockRepository.GenerateStub<IVillaChecker>();
        }


        [Test()]
        public void WhenFlightsAndVillasHolidaysAreAvailable()
        {
            stubFlightChecker.Stub(flight => flight.Check(year, week)).Return(true);
            stubVillaChecker.Stub(villa => villa.Check(year, week)).Return(new string[] { "Casa Blanca", "Golden Fields" });
            
            HolidayChecker holidayChecker = new HolidayChecker(stubFlightChecker, stubVillaChecker);

            Assert.That(holidayChecker.Check(year, week), Is.EqualTo(new string[] {"Casa Blanca", "Golden Fields"}));
        }

        [Test()]
        public void WhenFlightsAndNoVillasHolidaysNotAvailable()
        {
            stubFlightChecker.Stub(flight => flight.Check(year, week)).Return(true);
            stubVillaChecker.Stub(villa => villa.Check(year, week)).Return(new string[] {});

            HolidayChecker holidayChecker = new HolidayChecker(stubFlightChecker, stubVillaChecker);

            Assert.That(holidayChecker.Check(year, week), Is.EqualTo(new string[] {})); 
        }

        [Test()]
        public void WhenNoFlightsAndVillasHolidaysNotAvailable()
        {
            stubFlightChecker.Stub(flight => flight.Check(year, week)).Return(false);
            stubVillaChecker.Stub(villa => villa.Check(year, week)).Return(new string[] { "Casa Blanca", "Golden Fields" });

            HolidayChecker holidayChecker = new HolidayChecker(stubFlightChecker, stubVillaChecker);
        
            Assert.That(holidayChecker.Check(year, week), Is.EqualTo(new string[] {}));        }
        }
}

