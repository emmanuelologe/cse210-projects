using System;

namespace FitnessCenter
{
    public class Activity
    {
        private DateTime _date;
        protected int _lengthMinutes;

        public Activity(DateTime date, int lengthMinutes)
        {
            _date = date;
            _lengthMinutes = lengthMinutes;
        }

        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return 0;
        }

        public virtual double GetPace()
        {
            return 0;
        }

        public string GetSummary()
        {
            string summary = $"{_date:dd MMM yyyy} {GetType().Name} ({_lengthMinutes} min) - ";
            summary += $"Distance: {GetDistance():F1} {GetDistanceUnit()}, ";
            summary += $"Speed: {GetSpeed():F1} {GetSpeedUnit()}, ";
            summary += $"Pace: {GetPace():F1} {GetPaceUnit()}";
            return summary;
        }

        protected virtual string GetDistanceUnit()
        {
            return "km";
        }

        protected virtual string GetSpeedUnit()
        {
            return "kph";
        }

        protected virtual string GetPaceUnit()
        {
            return "min per km";
        }
    }
}
