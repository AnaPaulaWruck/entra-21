using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaCadastroEdicaoForm : Form
    {
        // Armazenar o id do nome da unidade federativa para permitir a edição
        private int idEdicao = -1; 

        public UnidadeFederativaCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        // this => chama a classe de cima para fazer o InitializeComponent()
        public UnidadeFederativaCadastroEdicaoForm(UnidadeFederativa unidadeFederativa) : this() 
        {
            // Definido o valor do idEdicao para posteriormente saber qual registro deve ser alterado
            idEdicao = unidadeFederativa.Id;

            // Preenchido o campo do nome e o campo sigla com o valor do banco de dados
            textBoxNome.Text = unidadeFederativa.Nome;
            maskedTextBoxSigla.Text = unidadeFederativa.Sigla;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var sigla = maskedTextBoxSigla.Text.Trim();

            var unidadeFederativa = new UnidadeFederativa();
            unidadeFederativa.Nome = nome;
            unidadeFederativa.Sigla = sigla;

            // Instancia do objeto de UnidadeFederativaService que permitirá persistir o registro
            var unidadeFederativaService = new UnidadeFederativaService();

            // Verificar se está em modo de cadastro
            if (idEdicao == -1)
            {
                // Persistir a informação na tabela de unidades_federativas
                unidadeFederativaService.Cadastrar(unidadeFederativa);

                MessageBox.Show("Unidade Federativa cadastrada com sucesso!");

                Close();

                return;
            }

            unidadeFederativa.Id = idEdicao;

            // Atualizar a informação na tabela de unidades_federativas
            unidadeFederativaService.Editar(unidadeFederativa);

            MessageBox.Show("Unidade Federativa alterada com sucesso");

            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
