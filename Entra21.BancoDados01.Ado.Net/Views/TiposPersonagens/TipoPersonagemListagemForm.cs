using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TipoPersonagemListagemForm : Form
    {
        private TipoPersonagemService tipoPersonagemService;

        public TipoPersonagemListagemForm()
        {
            InitializeComponent();

            // Instanciado objeto da classe TipoPersonagemService para permitir:
            // - Listar todos
            // - Editar
            // - Apagar

            tipoPersonagemService = new TipoPersonagemService();
        }

        private void TipoPersonagemListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tipoPersonagemCadastroEdicao = new TipoPersonagemCadastroEdicaoForm();

            tipoPersonagemCadastroEdicao.ShowDialog();

            AtualizarRegistrosDataGridView();
        }

        private void AtualizarRegistrosDataGridView()
        {
            // Obter todos os tipos de personagem cadastrados na tabela tipos_personagens
            var tiposPersonagens = tipoPersonagemService.ObterTodos();

            // Removido todos os registros do dataGriedViewTiposPersonagens
            dataGridViewTiposPersonagens.Rows.Clear();

            // Percorrido todos os tipos de personagens encontrados para adicionar no dataGridView permitindo o usuário visualizar eles
            for (int i = 0; i < tiposPersonagens.Count; i++)
            {
                var tipoPersonagem = tiposPersonagens[i];

                dataGridViewTiposPersonagens.Rows.Add(new object[]
                {
                    tipoPersonagem.Id,
                    tipoPersonagem.Tipo
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewTiposPersonagens.SelectedRows[0].Cells[0].Value);

            tipoPersonagemService.Apagar(id);

            AtualizarRegistrosDataGridView();

            MessageBox.Show("Registro apagado com sucesso!");
        }

        private void buttonEditar_Click(object sender, EventArgs e) 
        {
            if (dataGridViewTiposPersonagens.Rows.Count == 0)
            {
                MessageBox.Show("Cadastrar algum tipo de personagem");
                return;
            }

            if(dataGridViewTiposPersonagens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum registro");
                return;
            }

            // Obter a linha selecionada
            var linhaSelecionada = dataGridViewTiposPersonagens.SelectedRows[0];

            // Obter o id da linha selecionada
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Obter do banco de dados o tipo de personagem selecionado
            var tipoPersonagem = tipoPersonagemService.ObterPorId(id);

            // Instanciado objeto do form para permitir edição passando o tipo personagem, que permitirá
            // preencher os campos com os dados do Banco de Dados
            var tipoPersonagemForm = new TipoPersonagemCadastroEdicaoForm(tipoPersonagem);
            // Apresentado o form para o usuário
            tipoPersonagemForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }
    }
}
