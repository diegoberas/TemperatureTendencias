using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestTemperature
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_5Celcius_ToKevin()
        {
            double expected = 278.15;
            double result = TemperatureLib.Temper.ToKelvin(5, "C");
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Test_5Fahrenheit_ToKevin()
        {
            double expected = 258.15;
            double result = TemperatureLib.Temper.ToKelvin(5, "F");
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Test_10Kelvin_ToCelsius()
        {
            double expected = -263.15;
            double result = TemperatureLib.Temper.ToCelcius(10, "K");
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Test_50Fahrenheit_ToCelsius()
        {
            double expected = 10;
            double result = TemperatureLib.Temper.ToCelcius(50, "F");
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Test_300Kelvin_ToFahrenheit()
        {
            double expected = 80.33;
            double result = TemperatureLib.Temper.ToFahrenheit(300, "K");
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Test_30Celcius_ToFahrenheit()
        {
            double expected = 86;
            double result = TemperatureLib.Temper.ToFahrenheit(30, "C");
            Assert.AreEqual(expected, result);

        }
    }
}
