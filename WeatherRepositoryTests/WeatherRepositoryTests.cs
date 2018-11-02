using System;
using Exercise_WeatherRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeatherRepositoryTests
{
    [TestClass]
    public class WeatherRepositoryTests
    {
        //-- Field
        private Weather _weather;
        private WeatherRepository _weatherRepo;

        [TestInitialize]
        //-- TestInit (Arrange)
        public void Arrange()
        {
            _weatherRepo = new WeatherRepository();
            Weather newWeather = new Weather
            {
                WeatherID = 1,
                IsPrecipitating = true,
                WindSpeed = 30,
                WindDirection = Direction.East,
                Temperature = 55
            };
            _weatherRepo.AddWeatherToList(newWeather);
        }

        [TestMethod]
        public void WeatherRepo_NumberOfItemsInList_IsCorrectInt()
        {
            //-- Act
            var expected = 1;
            var actual = _weatherRepo.GetList().Count;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
