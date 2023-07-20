using System;

namespace FitnessCenter
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * 50 / 1000.0;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / _lengthMinutes) * 60;
        }

        public override double GetPace()
        {
            return _lengthMinutes / GetDistance();
        }

        protected override string GetDistanceUnit()
        {
            return "km";
        }

        protected override string GetSpeedUnit()
        {
            return "kph";
        }

        protected override string GetPaceUnit()
        {
            return "min per km";
        }
    }
}
