﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class ExemploTemperatura
    {
        public void Executar()
        {
            var temperatura = new Temperatura();
            temperatura.EscalaOrigemTemperatura = "C";
            temperatura.EscalaDestinoTemperatura = "F";
            temperatura.ValorTemperatura = 42.30;

            temperatura.ApresentarTemperaturaConvertida();

            // Console.WriteLine($"Temperatura convertida = {temperatura.ApresentarTemperaturaConvertida()}");
        }
    }
}
