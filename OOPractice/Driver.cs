namespace OOPractice
{
    using System;
    public class Driver
    {
        private Vehicle vehicle;
        public Driver(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string SpeedUp()
        {
            return this.vehicle.SpeedUp();
        }
    }
}
