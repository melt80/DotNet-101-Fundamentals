using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types
{
    class Program
    {
        public enum GenderType
        {
            Male, Female, Unknown
        }

        static void Main(string[] args)
        {
            //-- Integers
            int i = 100;

            //--Decleration (left side)
            int myAge;

            //--Initialization (right side)
            myAge = 42;
            
            //-- Other Types
            decimal p = 7.8m;
            double d = 780.01; //double takes longer to process than decimal
            float PI = 3.14159f;
            Console.WriteLine(PI);
            int? noValue = null;
            long youtubeMinutesWatched = 923424245925252525;
            byte by = 255;
            short sh = 32767;
            System.Console.WriteLine(youtubeMinutesWatched);

            //-- Booleans
            bool isEarly = true;
            //--Boolean Logic/Conditionals
            if(isEarly)
                System.Console.WriteLine("Need more coffee.");

            //-- Declare Enum
            GenderType myGender = GenderType.Male;
            var jenna = GenderType.Female;

            var myBirthYear = "1976";

            switch (myGender)
            {
                case GenderType.Male:
                    System.Console.WriteLine("Welcome Sir");
                    break;

                case GenderType.Female:
                    System.Console.WriteLine("Welcome ma'am!");
                    break;
            }

        }
    }
}
