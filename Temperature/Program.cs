using System;
using TemperatureLib;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"#### TemperatureConverter ####");
            Console.Write($"[Temperature]: ");
            double temp = double.Parse(Console.ReadLine());
            Console.Write($"[Scale]: ");
            string scale = Console.ReadLine().ToUpper();
            Console.Write($"[Scale to convert]: ");
            char answer = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine($"TempConverter {temp}{scale} to {answer}");

            switch (answer)
            {
                case 'K':
                    Console.WriteLine("To Kelvin: " + Temper.ToKelvin(temp, scale));
                    break;
                case 'C':
                    Console.WriteLine("To Celsius: " + Temper.ToCelcius(temp, scale));
                    break;
                case 'F':
                    Console.WriteLine("To Fahrenheit: " + Temper.ToFahrenheit(temp, scale));
                    break;

                default:
                    Console.WriteLine("Error. Intentalo de nuevo!");
                    break;
            }



            
        }
    }
}
