using Entra21.ExemplosOrientacaoObjetos.Produtos;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExemplosOrientacaoObjetos.Tests.Produtos
{
    public class ProdutoTests
    {
        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Menor_Hoje()
        {
            // Arrange (preparar os dados)
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(-1);

            // Act (ato de execução do método que deseja testar)
            var produtoVencido = produto.EhVencido();

            // Assert (validação do que foi gerado)
            // produtoVencido.Should().Be(true);
            produtoVencido.Should().BeTrue();
        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Maior_Hoje()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(1);

            // Act
            var vencido = produto.EhVencido();

            // Assert
            vencido.Should().BeFalse();
        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Igual_Hoje()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            // Act
            var vencido = produto.EhVencido();

            // Assert
            vencido.Should().BeTrue();
        }

        [Fact]
        public void Validar_EstaEmPromocao_Verdadeiro()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(3);

            // Act
            var emPromocao = produto.EstaEmPromocao();

            // Assert
            emPromocao.Should().BeTrue();
        }

        [Fact]
        public void Validar_EstaEmPromocao_Falso()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            // Act
            var emPromocao = produto.EstaEmPromocao();

            // Assert
            emPromocao.Should().BeFalse();
        }
    }
}
