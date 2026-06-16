using System;

namespace FitnessTracker
{
    public abstract class Activity
    {
        // Encapsulamiento
        private string _date;
        private int _durationInMinutes;

        public Activity(string date, int durationInMinutes)
        {
            _date = date;
            _durationInMinutes = durationInMinutes;
        }

        
        protected int DurationInMinutes => _durationInMinutes;

       
        public abstract double GetDistance();

        public abstract double GetSpeed();

        public abstract double GetPace();

        
        public virtual string GetSummary()
        {

            return $"{_date} {GetType().Name} ({_durationInMinutes} min) - " +
                   $"Distance {GetDistance():F1} km, " +
                   $"Speed {GetSpeed():F1} kph, " +
                   $"Pace: {GetPace():F1} min per km";

        }
    }
}
