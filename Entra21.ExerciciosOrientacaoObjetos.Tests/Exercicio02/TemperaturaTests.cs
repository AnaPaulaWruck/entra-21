using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetos.Tests.Exercicio02
{
    public class TemperaturaTests
    {
        [Fact]
        public void Validar_CalcularFahrenheitParaCelsius()
        {
            // Arrange
            Temperatura temperatura = new Temperatura();
            temperatura.ValorTemperatura = 42;

            // Act
            var temperaturaConvertida = temperatura.CalcularFahrenheitParaCelsius();

            // Assert
            temperaturaConvertida.Should().Be((42 - 32) / 1.8);
        }

        [Fact]
        public void Validar_CalcularKelvinParaCelsius()
        {
            // Arrange
            Temperatura temperatura = new Temperatura();
            temperatura.ValorTemperatura = 42;

            // Act 
            var temperaturaConvertida = temperatura.CalcularKelvinParaCelsius();

            // Assert
            temperaturaConvertida.Should().Be(42 - 273);
        }

        [Fact]
        public void Validar_CalcularCelsiusParaFahrenheit()
        {
            // Arrange
            Temperatura temperatura = new Temperatura();
            temperatura.ValorTemperatura = 42;

            // Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaFahrenheit();

            // Assert
            temperaturaConvertida.Should().Be((42 * 1.8) + 32);
        }

        [Fact]
        public void Validar_CalcularKelvinParaFahrenheit()
        {
            // Arrange
            Temperatura temperatura = new Temperatura();
            temperatura.ValorTemperatura = 42;

            // Act
            var temperaturaConvertida = temperatura.CalcularKelvinParaFahrenheit();

            // Assert
            temperaturaConvertida.Should().Be((42 - 273) * 1.8 + 32);
        }

        [Fact]
        public void Validar_CalcularCelsiusParaKelvin()
        {
            // Arrange
            Temperatura temperatura = new Temperatura();
            temperatura.ValorTemperatura = 42;

            // Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaKelvin();

            // Assertcon
            temperaturaConvertida.Should().Be(42 + 273);
        }

        [Fact]
        public void Validar_CalcularFahrenheitParaKelvin()
        {
            // Arrange
            Temperatura temperatura = new Temperatura();
            temperatura.ValorTemperatura = 42;

            // Act
            var temperaturaConvertida = temperatura.CalcularFahrenheitParaKelvin();

            // Assert
            temperaturaConvertida.Should().Be((42 - 32) * (5 / 9) + 273);
        }
    }
}
