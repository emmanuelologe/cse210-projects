using System;

namespace FitnessCenter
{
    public class StationaryBicycle : Activity
    {
        private double _speedKph;

        public StationaryBicycle(DateTime date, int lengthMinutes, double speedKph) : base(date, lengthMinutes)
        {
            _speedKph = speedKph;
        }

        public override double GetSpeed()
        {
            return _speedKph;
        }

        public override double GetPace()
        {
            return 60 / _speedKph;
        }
    }
}
