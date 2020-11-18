namespace OOPractice
{
    using System;
    public class Vehicle
    {
        private string name;
        private double speed;
        public Vehicle(string name, double speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            return $"{this.name}: speed up {this.speed} km/h";
        }
    }
}
