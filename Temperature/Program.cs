using System;
using TemperatureLib;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Temper t = new Temper();
            Console.WriteLine("Introduzca la temperatura: ");
            double temp = t.TemperatureDigit = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la escala [Kelvin] [Celcius] [Fahrenheit]: ");
            string scale = t.Scale = Console.ReadLine().ToLower();
            Console.Write("Convertir a [1]Kelvin [2]Celcius [3]Fahrenheit: ");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    Console.WriteLine("To Kelvin: " + Temper.ToKelvin(temp, scale));
                    break;
                case 2:
                    Console.WriteLine("To Celsius: " + Temper.ToCelcius(temp, scale));
                    break;
                case 3:
                    Console.WriteLine("To Fahrenheit: " + Temper.ToFahrenheit(temp, scale));
                    break;

                default:
                    Console.WriteLine("Error. Intentalo de nuevo!");
                    break;
            }



            
        }
    }
}
