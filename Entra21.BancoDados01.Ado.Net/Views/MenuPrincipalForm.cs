using Entra21.BancoDados01.Ado.Net.Views.Cidades;
using Entra21.BancoDados01.Ado.Net.Views.Personagens;
using Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens;
using Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas;

namespace Entra21.BancoDados01.Ado.Net.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonEditoras_Click(object sender, EventArgs e)
        {
            // Não tem Form feito
        }

        private void buttonPersonagens_Click(object sender, EventArgs e)
        {
            var personagemForm = new PersonagemListagemForm();
            personagemForm.ShowDialog();
        }

        private void buttonTiposPersonagens_Click(object sender, EventArgs e)
        {
            var tipoPersonagemForm = new TipoPersonagemListagemForm();
            tipoPersonagemForm.ShowDialog();
        }

        private void buttonCidades_Click(object sender, EventArgs e)
        {
            var cidadeForm = new CidadeListagemForm();
            cidadeForm.ShowDialog();
        }

        private void buttonUnidadesFederativas_Click(object sender, EventArgs e)
        {
            var unidadeFederativaForm = new UnidadeFederativaListagemForm();
            unidadeFederativaForm.ShowDialog();
        }
    }
}
