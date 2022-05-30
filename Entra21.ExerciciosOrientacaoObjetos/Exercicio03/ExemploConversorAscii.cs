using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio03
{
    public class ExemploConversorAscii
    {
        public void Executar()
        {
            var conversorAscii = new ConversorAscii();
            conversorAscii.Caracter = "d";

            conversorAscii.ObterCodigoAsciiCaracter();

            //Console.WriteLine($"Caracter {conversorAscii.Caracter} = ASCII {conversorAscii.ObterCodigoAsciiCaracter()}");
        }
    }
}
