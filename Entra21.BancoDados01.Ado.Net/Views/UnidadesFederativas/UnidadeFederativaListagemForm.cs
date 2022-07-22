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
            // Obter todas as unidades federativas cadastradas na tabela unidades_federativas
            var unidadesFederativas = unidadeFederativaService.ObterTodos();

            // Removido todos os registros do dataGridViewUnidadesFederativas
            dataGridViewUnidadesFederativas.Rows.Clear();

            // Percorrido todas as unidades federativas encontradas para adicionar no dataGridView permitindo o usuário visualizar eles
            for (int i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];

                dataGridViewUnidadesFederativas.Rows.Add(new object[]
                {
                    unidadeFederativa.Id,
                    unidadeFederativa.Sigla,
                    unidadeFederativa.Nome
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewUnidadesFederativas.SelectedRows[0].Cells[0].Value);

            unidadeFederativaService.Apagar(id);

            AtualizarRegistrosDataGridView();

            MessageBox.Show("Registro apagado com sucesso!");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUnidadesFederativas.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma Unidade Federativa");
                return;
            }

            if (dataGridViewUnidadesFederativas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro");
                return;
            }

            // Obter a linha selecionada
            var linhaSelecionada = dataGridViewUnidadesFederativas.SelectedRows[0];

            // Obter o id da linha selecionada
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Obter do banco de dados a unidade federativa selecionada
            var unidadeFederativa = unidadeFederativaService.ObterPorId(id);

            // Instanciado objeto do form para permitir edição passando a unidade federatica, que permitirá
            // preencher os campos com os dados do Banco de Dados
            var unidadeFederativaForm = new UnidadeFederativaCadastroEdicaoForm(unidadeFederativa);
            // Apresentado o form para o usuário
            unidadeFederativaForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var unidadeFederativaCadastroEdicao = new UnidadeFederativaCadastroEdicaoForm();

            unidadeFederativaCadastroEdicao.ShowDialog();

            AtualizarRegistrosDataGridView();
        }
    }
}
