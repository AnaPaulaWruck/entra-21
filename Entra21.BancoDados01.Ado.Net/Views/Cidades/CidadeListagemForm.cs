using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    public partial class CidadeListagemForm : Form
    {
        // Readonly para permitir a criação da instancia somente no construtor
        private readonly CidadeService _cidadeService;

        public CidadeListagemForm()
        {
            InitializeComponent();

            _cidadeService = new CidadeService();

            PreencherDataGridViewComCidades();
        }

        private void PreencherDataGridViewComCidades()
        {
            var cidades = _cidadeService.ObterTodos();

            dataGridViewCidades.Rows.Clear();

            for (int i = 0; i < cidades.Count; i++)
            {
                var cidade = cidades[i];

                dataGridViewCidades.Rows.Add(new object[]
                {
                    cidade.Id,
                    cidade.Nome,
                    cidade.UnidadeFederativa.Sigla,
                    cidade.DataHoraFundacao,
                    cidade.QuantidadeHabitantes,
                    cidade.Pib
                });
            }
        }
    }
}
