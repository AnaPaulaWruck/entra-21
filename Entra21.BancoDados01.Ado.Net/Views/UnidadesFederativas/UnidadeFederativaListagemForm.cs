using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaListagemForm : Form
    {
        private UnidadeFederativaService unidadeFederativaService;
        public UnidadeFederativaListagemForm()
        {
            InitializeComponent();

            unidadeFederativaService = new UnidadeFederativaService();
        }

        private void UnidadeFederativaListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGridView();
        }

        private void AtualizarRegistrosDataGridView()
        {
            throw new NotImplementedException();
        }
    }
}
