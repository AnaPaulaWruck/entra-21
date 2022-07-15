using Entra21.BancoDados01.Ado.Net.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
