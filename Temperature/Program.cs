using System;
using TemperatureLib;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Temper();
            Console.WriteLine()
            string scale = t.Scale = "celsius";
            double temp = t.TemperatureDigit = 5;
            Console.WriteLine(Temper.ToKelvin(temp, scale));
        }
    }
}
