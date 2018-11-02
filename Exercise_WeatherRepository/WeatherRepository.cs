using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_WeatherRepository
{
    public class WeatherRepository
    {
        private List<Weather> _weatherList = new List<Weather>();

        public void AddWeatherToList(Weather weather)
        {
            _weatherList.Add(weather);
        }

        public List<Weather> GetList()
        {
            return _weatherList;
        }
    }
}
