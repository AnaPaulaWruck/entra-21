namespace Entra21.BancoDados01.Ado.Net.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeHabitantes { get; set; }
        public DateTime DataFundacao { get; set; }
        public decimal Pib { get; set; }

        // Será preenchido com INNER JOIN
        public UnidadeFederativa UnidadeFederativa { get; set; }
    }
}
