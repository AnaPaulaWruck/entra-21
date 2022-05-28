using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class Temperatura
    {
        public string EscalaOrigemTemperatura;
        public string EscalaDestinoTemperatura;
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
            if (EscalaOrigemTemperatura.StartsWith("F") && EscalaDestinoTemperatura.StartsWith("C"))
            {
                return CalcularFahrenheitParaCelsius();
            }
            else if (EscalaOrigemTemperatura.StartsWith("K") && EscalaDestinoTemperatura.StartsWith("C"))
            {
                return CalcularKelvinParaCelsius();
            }
            else if (EscalaOrigemTemperatura.StartsWith("C") && EscalaDestinoTemperatura.StartsWith("F"))
            {
                return CalcularCelsiusParaFahrenheit();
            }
            else if (EscalaOrigemTemperatura.StartsWith("K") && EscalaDestinoTemperatura.StartsWith("F"))
            {
                return CalcularKelvinParaFahrenheit();
            }
            else if (EscalaOrigemTemperatura.StartsWith("C") && EscalaDestinoTemperatura.StartsWith("K"))
            {
                return CalcularCelsiusParaKelvin();
            }
            else if (EscalaOrigemTemperatura.StartsWith("F") && EscalaDestinoTemperatura.StartsWith("K"))
            {
                return CalcularFahrenheitParaKelvin();
            }

            return ValorTemperatura;
        }
    }
}
