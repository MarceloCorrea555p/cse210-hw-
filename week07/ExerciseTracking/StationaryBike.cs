namespace FitnessTracker
{
    public class StationaryBike : Activity
    {
        private double _speedInKph;

        public StationaryBike(string date, int durationInMinutes, double speedInKph) 
            : base(date, durationInMinutes)
        {

            _speedInKph = speedInKph;

        }

        public override double GetDistance()
        {

            return (_speedInKph * DurationInMinutes) / 60;
        }

        public override double GetSpeed()
        {

            return _speedInKph;

        }

        public override double GetPace()
        {
            return 60 / _speedInKph;
            
        }
    }
}
