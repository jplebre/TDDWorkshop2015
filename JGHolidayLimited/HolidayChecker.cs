using System;

namespace JGHolidayLimited
{
    public class HolidayChecker
    {
        private IFlightChecker _flightChecker;
        private IVillaChecker _villaChecker;

        public HolidayChecker(IFlightChecker flightChecker, IVillaChecker villaChecker)
        {
            _flightChecker = flightChecker;
            _villaChecker = villaChecker;
        }

        public string[] Check(int year, int week){
            if (_flightChecker.Check(year,week))
            {
                return _villaChecker.Check(year,week);
            }
                
            return new string[]{};
        }
    }
}

