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
        public string[] CategoriasMedicacao = new string[3]; // Exemplo: Antibiotico, Analgesico

        public double CalcularTotalPedido()
        {
            double totalPedido = 0;
            for (var i = 0; i < NomesMedicacao.Length; i++)
            {
                totalPedido += PrecosMedicacao[i];
            }

            return totalPedido;
        }

        public void ApresentarTotalPedido()
        {
            CalcularTotalPedido();
        }

        public double CalcularValorAntibioticos()
        {
            double totalPedidoAntibioticos = 0;
            for (var i = 0; i < NomesMedicacao.Length; i++)
            {
                if (CategoriasMedicacao[i] == "antibiótico" || CategoriasMedicacao[i] == "antibiotico")
                {
                    totalPedidoAntibioticos += PrecosMedicacao[i];
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
            for (var i = 0; i < NomesMedicacao.Length; i++)
            {
                if (CategoriasMedicacao[i] == "antibiótico" || CategoriasMedicacao[i] == "antibiotico")
                {
                    quantidadeAntibioticos++;
                }
            }

            return quantidadeAntibioticos;
        }

        public void ApresentarQuantidadeAntibioticos()
        {
            CalcularQuantidadeAntibioticos();
        }

        public double CalcularValorAnalgesicos()
        {
            double totalPedidosAnalgesicos = 0;
            for (var i = 0; i < NomesMedicacao.Length; i++)
            {
                if (CategoriasMedicacao[i] == "analgésico" || CategoriasMedicacao[i] == "analgesico")
                {
                    totalPedidosAnalgesicos += PrecosMedicacao[i];
                }
            }

            return totalPedidosAnalgesicos;
        }

        public void ApresentarValorAnalgesicos()
        {
            CalcularValorAnalgesicos();
        }

        public int CalcularQuantidadeAnalgesicos()
        {
            int quantidadeAnalgesicos = 0;
            for (var i = 0; i < NomesMedicacao.Length; i++)
            {
                if (CategoriasMedicacao[i] == "analgésico" || CategoriasMedicacao[i] == "analgesico")
                {
                    quantidadeAnalgesicos++;
                }
            }

            return quantidadeAnalgesicos;
        }

        public void ApresentarQuantidadeAnalgesicos()
        {
            CalcularQuantidadeAnalgesicos();
        }
    }
}

/*
    Criar métodos:
- Apresentar total do pedido / Calcular, Apresentar
- Apresentar total do pedido por categoria de produto / Verificar categoria, Calcular, Apresentar
    Exemplo:
    Analgésico total 15,78
    Antibiótico total 32.50

- Apresentar quantidade por categoria / Calcular quantidade por categoria, Apresentar
- Apresentar nome do produto mais caro / Obter mais caro, Apresentar
- Apresentar nome e categoria do produto mais barato / Obter mais barato, Apresentar
*/


// TDD 
// rippsters.tech