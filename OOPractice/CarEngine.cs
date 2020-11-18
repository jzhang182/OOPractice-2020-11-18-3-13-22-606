namespace OOPractice
{
    using System;
    public interface ICarEngine
    {
        public double GetSpeed();
    }

    public class GasolineEngine : ICarEngine
    {
        public GasolineEngine()
        {
        }

        public double GetSpeed()
        {
            return 30;
        }
    }

    public class ElectricEngine : ICarEngine
    {
        public ElectricEngine()
        {
        }

        public double GetSpeed()
        {
            return 25;
        }
    }
}
