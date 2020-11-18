namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class VehicleTest
    {
        [Fact]
        public void Should_show_message_of_car()
        {
            //given
            var car = new Car("Cool Car", new GasolineEngine());
            //when
            string actual = car.SpeedUp();
            //then
            Assert.Equal("Cool Car: speed up 30 km/h", actual);
        }

        [Fact]
        public void Should_show_message_of_truck()
        {
            //given
            var truck = new Truck("Big Truck", 10);
            //when
            string actual = truck.SpeedUp();
            //then
            Assert.Equal("Big Truck: speed up 10 km/h", actual);
        }

        [Fact]
        public void Should_show_message_when_driver_truck()
        {
            //given
            var driver = new Driver(new Truck("Big Truck", 10));
            //when
            string actual = driver.SpeedUp();
            //then
            Assert.Equal("Big Truck: speed up 10 km/h", actual);
        }

        [Fact]
        public void Should_show_message_when_driver_car()
        {
            //given
            var driver = new Driver(new Car("Cool Car", new GasolineEngine()));
            //when
            string actual = driver.SpeedUp();
            //then
            Assert.Equal("Cool Car: speed up 30 km/h", actual);
        }
    }
}
