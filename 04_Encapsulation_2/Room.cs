using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_2
{
    public class Room
    {
        private const double MAX_LENGTH = 30d;
        private const double MIN_LENGTH = 6d;
        private const double MAX_WIDTH = 30d;
        private const double MIN_WIDTH = 6d;
        private const double MAX_HEIGHT = 12d;
        private const double MIN_HEIGHT = 10d;
        private double _length;
        private double _width;
        private double _height;


        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length
        {
            get => _length;
            set
            {
                if (value < MIN_LENGTH || value > MAX_LENGTH)
                {
                    throw new ArgumentOutOfRangeException("Length must be between 6 and 30.");
                }

                _length = value;

            }
        }
        public double Width
        {
            get => _width;
            set
            {
                if (value < MIN_LENGTH || value > MAX_LENGTH)
                {
                    throw new ArgumentOutOfRangeException("Length must be between 6 and 30.");
                }

                _width = value;

            }
        }

        public double Height
        {
            get => _height;
            set
            {
                if (value < MIN_HEIGHT || value > MAX_HEIGHT)
                {
                    throw new ArgumentOutOfRangeException("Height must be between 10 and 12.");
                }

                _height = value;
            }
        }

        public double GetLateralSurfaceArea()
        {
            var widthWallSurfaceArea = Width * Height;
            var lengthWallSurfaceArea = Length * Height;
            return (widthWallSurfaceArea * 2) + (lengthWallSurfaceArea * 2);

        }

    }
}
