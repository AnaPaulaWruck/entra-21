using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio04
{
    public class Farmacia
    {
        public string RazaoSocial;
        public int Cnpj;
        public string[] NomesMedicacao = new string[3];
        public double[] PrecosMedicacao = new double[3];
        public string[] CategoriasMedicacao = new string[3]; // Antibiotico , Antiinflamatorio , Analgesico

        public double CalcularTotalPedido()
        {
            double totalPedido = 0;
            for (var i = 0; i < PrecosMedicacao.Length; i++)
            {
                totalPedido += PrecosMedicacao[i];
            }

            return totalPedido;
        }

        public void ApresentarTotalPedido()
        {
            CalcularTotalPedido();
        }

        public bool VerificarEhAntibiotico()
        {
            for (var i = 0; i < NomesMedicacao.Length; i++)
            {
                if (CategoriasMedicacao[i] == "Antibiótico" || CategoriasMedicacao[i] == "Antibiotico")
                {
                    return true;
                }
            }

            return false;
        }

        public double CalcularValorAntibioticos()
        {
            double totalPedidoAntibioticos = 0;
            if (VerificarEhAntibiotico() == true)
            {
                for (var i = 0; i < PrecosMedicacao.Length; i++)
                {
                    if (CategoriasMedicacao[i] == "Antibiotico")
                    {
                        totalPedidoAntibioticos += PrecosMedicacao[i];
                    }
                }
            }

            return totalPedidoAntibioticos;
        }

        public void ApresentarValorAntibioticos()
        {
            CalcularValorAntibioticos();
        }

        public int CalcularQuantidadeAntibioticos()
        {
            int quantidadeAntibioticos = 0;
            if (VerificarEhAntibiotico() == true)
            {
                for (var i = 0; i < NomesMedicacao.Length; i++)
                {
                    if (CategoriasMedicacao[i] == "Antibiotico")
                    {
                        quantidadeAntibioticos += 1;
                    }
                }
            }

            return quantidadeAntibioticos;
        }

        public void ApresentarQuantidadeAntibioticos()
        {
            CalcularQuantidadeAntibioticos();
        }

        public bool VerificarEhAntiinflamatorio()
        {
            for (var i = 0; i < NomesMedicacao.Length; i++)
            {
                if (CategoriasMedicacao[i] == "Antiinflamatório" || CategoriasMedicacao[i] == "Antiinflamatorio")
                {
                    return true;
                }
            }

            return false;
        }

        public double CalcularValorAntiinflamatorios()
        {
            double totalPedidosAntiinflamatorios = 0;
            if (VerificarEhAntiinflamatorio() == true)
            {
                for(var i=0;i< )
            }
        }

        public bool VerificarEhAnalgesico()
        {
            for (var i = 0; i < NomesMedicacao.Length; i++)
            {
                if (CategoriasMedicacao[i] == "Analgésico" || CategoriasMedicacao[i] == "Analgesico")
                {
                    return true;
                }
            }

            return false;
        }

    }
}

/*
    Criar métodos:
- Apresentar total do pedido / Calcular, Apresentar
- Apresentar total do pedido por categoria de produto / Verificar categoria, Calcular, Apresentar
    Exemplo:
    Antiinflamatório total 15,78
    Antibiótico total 32.50

- Apresentar quantidade por categoria / Calcular quantidade por categoria, Apresentar
- Apresentar nome do produto mais caro / Obter mais caro, Apresentar
- Apresentar nome e categoria do produto mais barato / Obter mais barato, Apresentar
*/


// TDD 
// rippsters.tech