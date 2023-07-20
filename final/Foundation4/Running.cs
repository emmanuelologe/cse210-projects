using System;

namespace FitnessCenter
{
    public class Running : Activity
    {
        private double _distanceMiles;

        public Running(DateTime date, int lengthMinutes, double distanceMiles) : base(date, lengthMinutes)
        {
            _distanceMiles = distanceMiles;
        }

        public override double GetDistance()
        {
            return _distanceMiles;
        }

        public override double GetSpeed()
        {
            return (_distanceMiles / _lengthMinutes) * 60;
        }

        public override double GetPace()
        {
            return _lengthMinutes / _distanceMiles;
        }

        protected override string GetDistanceUnit()
        {
            return "miles";
        }

        protected override string GetSpeedUnit()
        {
            return "mph";
        }

        protected override string GetPaceUnit()
        {
            return "min per mile";
        }
    }
}
