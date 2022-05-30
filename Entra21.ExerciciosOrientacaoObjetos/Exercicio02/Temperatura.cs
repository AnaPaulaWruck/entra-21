using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class Temperatura
    {
        public string EscalaOrigem;
        public string EscalaDestino;
        public double ValorTemperatura;

        public double CalcularFahrenheitParaCelsius()
        {
            return (ValorTemperatura - 32) / 1.8;
        }

        public double CalcularKelvinParaCelsius()
        {
            return ValorTemperatura - 273;
        }

        public double CalcularCelsiusParaFahrenheit()
        {
            return (ValorTemperatura * 1.8) + 32;
        }

        public double CalcularKelvinParaFahrenheit()
        {
            return (ValorTemperatura - 273) * 1.8 + 32;
        }

        public double CalcularCelsiusParaKelvin()
        {
            return ValorTemperatura + 273;
        }

        public double CalcularFahrenheitParaKelvin()
        {
            return (ValorTemperatura - 32) * (5 / 9) + 273;
        }

        public double ApresentarTemperaturaConvertida()
        {
            if (EscalaOrigem.StartsWith("F") && EscalaDestino.StartsWith("C"))
            {
                return CalcularFahrenheitParaCelsius();
            }
            else if (EscalaOrigem.StartsWith("K") && EscalaDestino.StartsWith("C"))
            {
                return CalcularKelvinParaCelsius();
            }
            else if (EscalaOrigem.StartsWith("C") && EscalaDestino.StartsWith("F"))
            {
                return CalcularCelsiusParaFahrenheit();
            }
            else if (EscalaOrigem.StartsWith("K") && EscalaDestino.StartsWith("F"))
            {
                return CalcularKelvinParaFahrenheit();
            }
            else if (EscalaOrigem.StartsWith("C") && EscalaDestino.StartsWith("K"))
            {
                return CalcularCelsiusParaKelvin();
            }
            else if (EscalaOrigem.StartsWith("F") && EscalaDestino.StartsWith("K"))
            {
                return CalcularFahrenheitParaKelvin();
            }

            return ValorTemperatura;
        }
    }
}
