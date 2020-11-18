namespace OOPractice
{
    using System;
    public class Car : Vehicle
    {
        public Car(string name, ICarEngine carEngine) : base(name, carEngine.GetSpeed())
        {
        }
    }
}
