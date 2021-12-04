using System;

namespace TemperatureLib
{
    public class Temper
    {
       
  
        public static double ToKelvin(double x, string y)
        {
           
            if (y == "C")
            {
                return Math.Round(x + 273.15, 2);
            }
            else if (y == "F")
            {
                return Math.Round((x - 32) * 5 / 9 + 273.15, 2);
            }
            else
            {
                return x;
            }
            
            
        }

        public static double ToCelcius(double x, string y)
        {
            if (y == "K")
            {
                return Math.Round(x - 273.15, 2);
            }
            else if (y == "F")
            {
                return Math.Round((x - 32) * 5 / 9, 2);
            }
            else
            {
                return x;
            }
        }

        public static double ToFahrenheit(double x, string y)
        {
            if (y == "C")
            {
                return Math.Round((x * 9 / 5) + 32, 2);
            }
            else if (y == "K")
            {
                return Math.Round((x - 273.15) * 9 / 5 + 32, 2);
            }
            else
            {
                return x;
            }
        }





    }
}
