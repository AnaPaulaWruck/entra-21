using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio17
    {
        public void Executar()
        {
            int horas = 23, minutos = 59, segundos = 59;
            while (horas >= 0)
            {
                while (minutos >= 0)
                {
                    while(segundos >= 0)
                    {
                        Console.WriteLine(horas.ToString("D2") + ":" + minutos.ToString("D2") + ":" + segundos.ToString("D2"));
                        segundos = segundos - 1;
                    }
                    minutos = minutos - 1;
                    segundos = 59;
                }
                horas = horas - 1;
                minutos = 59;
                segundos = 59;
            }
        }
    }
}
