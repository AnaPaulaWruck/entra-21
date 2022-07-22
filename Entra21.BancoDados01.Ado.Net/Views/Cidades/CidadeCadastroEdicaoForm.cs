using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    public partial class CidadeCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public CidadeCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxUnidadeFederativa();

            _idParaEditar = -1;
        }

        public CidadeCadastroEdicaoForm(Cidade cidade) : this()
        {
            _idParaEditar = cidade.Id;

            textBoxNome.Text = cidade.Nome;

            // Percorrer cada um dos itens de unidade federativa, para selecionar o que o usuário tinha cadastrado anteriormente
            for (int i = 0; i < comboBoxUnidadeFederativa.Items.Count; i++)
            {
                var unidadeFederativaPercorrido = comboBoxUnidadeFederativa.Items[i] as UnidadeFederativa;

                if (unidadeFederativaPercorrido.Id == cidade.UnidadeFederativa.Id)
                {
                    comboBoxUnidadeFederativa.SelectedItem = unidadeFederativaPercorrido;
                    break;
                }
            }          
        }

        private void PreencherComboBoxUnidadeFederativa()
        {
            // Buscar todos as unidades federativas do banco de dados para permitir o usuário escolher
            var unidadeFederativaService = new UnidadeFederativaService();
            var unidadesFederativas = unidadeFederativaService.ObterTodos();

            for (int i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];
                comboBoxUnidadeFederativa.Items.Add(unidadeFederativa);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxUnidadeFederativa.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma unidade federativa.");
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var unidadeFederativa = comboBoxUnidadeFederativa.SelectedItem as UnidadeFederativa;
            var quantidadeHabitantes = textBoxquantidadeHabitantes.Text.Trim();
            var dataHoraFundacao = dateTimePickerDataHoraFundacao.Value;
            var pib = textBoxPib.Text.Trim();

            var cidade = new Cidade();
            cidade.Nome = nome;
            cidade.UnidadeFederativa = unidadeFederativa;
            cidade.QuantidadeHabitantes = Convert.ToInt32(quantidadeHabitantes);
            cidade.DataHoraFundacao = Convert.ToDateTime(dataHoraFundacao);
            cidade.Pib = Convert.ToInt32(pib);

            // Persistir o que o usuário escolheu na tabela de cidades
            var cidadeService = new CidadeService();

            // Verificar se está no modo de cadastro
            if (_idParaEditar == -1)
            {
                // Modo de cadastro
                cidadeService.Cadastrar(cidade);
                MessageBox.Show("Cidade cadastrada com sucesso");
                Close();
            }
            else
            {
                // Modo de edição
                cidade.Id = _idParaEditar;
                cidadeService.Editar(cidade);
                MessageBox.Show("Cidade alterada com sucesso");
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
