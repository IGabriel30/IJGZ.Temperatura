using Microsoft.VisualStudio.TestTools.UnitTesting;
using IJGZ.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJGZ.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            // Arrange
            TemperatureConverter convertidor = new TemperatureConverter();

            // Act
            double result = convertidor.CelsiusToFahrenheit(100); 

            // Assert
            Assert.AreEqual(212, result, 0.001);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            // Arrange
            TemperatureConverter convertidor = new TemperatureConverter();

            // Act
            double result = convertidor.FahrenheitToCelsius(212);

            // Assert
            Assert.AreEqual(100, result, 0.001);
        }
    }
}