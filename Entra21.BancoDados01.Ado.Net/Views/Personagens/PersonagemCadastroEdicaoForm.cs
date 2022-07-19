using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    public partial class PersonagemCadastroEdicaoForm : Form // GREG
    {
        private readonly int _idParaEditar;
        public PersonagemCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxTipoPersonagem();

            PreencherComboBoxEditora();

            _idParaEditar = -1;
        }

        public PersonagemCadastroEdicaoForm(Personagem personagem) : this()
        {
            _idParaEditar = personagem.Id;

            textBoxNome.Text = personagem.Nome;

            // Percorrer cada um dos itend do tipo de personagem, para selecionar o que o usuário tinha cadastrado anteriormente
            for (int i = 0; i < comboBoxTipoPersonagem.Items.Count; i++)
            {
                var tipoPersonagemPercorrido = comboBoxTipoPersonagem.Items[i] as TipoPersonagem;

                if (tipoPersonagemPercorrido.Id == personagem.TipoPersonagem.Id)
                {
                    comboBoxTipoPersonagem.SelectedItem = tipoPersonagemPercorrido;
                    break; // Break vai parar o for e continuar o que está abaixo fora do for, return iria parar o método
                }
            }

            // Percorrer cada um dos itens da editora, para selecionar o que o usuário tinha cadastrado
            for (int i = 0; i < comboBoxEditora.Items.Count; i++)
            {
                var editoraPercorrida = comboBoxEditora.Items[i] as Editora;

                if (editoraPercorrida.Id == personagem.Editora.Id)
                {
                    comboBoxEditora.SelectedItem = editoraPercorrida;
                }
            }
        }

        // No Design do PersonagemCadastroEdicaoForm => no comboBoxEditora => abrir propriedades => escrever "Nome" em DisplayMember
        private void PreencherComboBoxEditora()
        {
            // Buscar todos os tipos de editoras do banco de dados para permitir o usuário escolher
            var editoraService = new EditoraService();
            var editoras = editoraService.ObterTodos();

            for (int i = 0; i < editoras.Count; i++)
            {
                var editora = editoras[i];
                comboBoxEditora.Items.Add(editora);
            }
        }

        // No Design do PersonagemCadastroEdicaoForm => no comboBoxTipoPersonagem => abrir propriedades => escrever "Tipo" em DisplayMember
        private void PreencherComboBoxTipoPersonagem()
        {
            // Buscar todos os tipos de personagens do banco de dados para permitir o usuário escolher
            var tipoPersonagemService = new TipoPersonagemService();
            var tipoPersonagens = tipoPersonagemService.ObterTodos();

            for (int i = 0; i < tipoPersonagens.Count; i++)
            {
                var tipoPersonagem = tipoPersonagens[i];
                comboBoxTipoPersonagem.Items.Add(tipoPersonagem);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxEditora.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma editora");
                return;
            }

            if (comboBoxTipoPersonagem.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de personagem");
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var tipoPersonagem = comboBoxTipoPersonagem.SelectedItem as TipoPersonagem;
            var editora = comboBoxEditora.SelectedItem as Editora;

            var personagem = new Personagem();
            personagem.Nome = nome;
            personagem.TipoPersonagem = tipoPersonagem;
            personagem.Editora = editora;

            // Persistir o que o usuário escolheu na tabela de personagns
            var personagemService = new PersonagemService();

            // Verificar se está no modo de cadastro
            if (_idParaEditar == -1)
            {
                // Modo de cadastro
                personagemService.Cadastrar(personagem);
                MessageBox.Show("Personagem cadastrado com sucesso");
                Close();
            }
            else
            {
                // Modo de edição
                personagem.Id = _idParaEditar;
                personagemService.Editar(personagem);
                MessageBox.Show("Personagem alterado com sucesso");
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

