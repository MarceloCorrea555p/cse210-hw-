namespace FitnessTracker
{
    public class Running : Activity
    {
        private double _distanceInKm;


        public Running(string date, int durationInMinutes, double distanceInKm) 
            : base(date, durationInMinutes)
        {
            
            _distanceInKm = distanceInKm;
        }

        public override double GetDistance()
        {

            return _distanceInKm;
        }

        public override double GetSpeed()
        {

            return (GetDistance() / DurationInMinutes) * 60;

        }

        public override double GetPace()

        {

            return DurationInMinutes / GetDistance();

        }
    }
}
