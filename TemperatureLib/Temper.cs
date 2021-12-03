using System;

namespace TemperatureLib
{
    public class Temper
    {
        public string Scale { get; set; }
        public double TemperatureDigit { get; set; }
        

        public static double ToKelvin(double x, string y)
        {
           
            if (y == "celsius")
            {
                return Math.Round(x + 273.15, 2);
            }
            else if (y == "fahrenheit")
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
            if (y == "kelvin")
            {
                return Math.Round(x - 273.15, 2);
            }
            else if (y == "fahrenheit")
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
            if (y == "celcius")
            {
                return Math.Round((x * 9 / 5) + 32, 2);
            }
            else if (y == "kelvin")
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
