using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_WeatherRepository
{
    public enum Direction
    {
        North = 1, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest
    }
    public class Weather
    {
        public int WeatherID { get; set; }
        public int Temperature { get; set; }
        public int WindSpeed { get; set; }
        public Direction WindDirection { get; set; }
        public bool IsPrecipitating { get; set; }
    
    }
}
