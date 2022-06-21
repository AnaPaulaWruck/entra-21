using Newtonsoft.Json;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private List<Paciente> pacientes;

        private int codigo = 0;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;

        public PacientesForm()
        {
            InitializeComponent();

            // Cria uma lista de objetos para armazenar os pacientes
            pacientes = new List<Paciente>();

            // Ler do arquivo json os pacientes cadastrados anteriormente
            LerArquivoApresentandoPacientes();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informações dos campos:
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            // Calcular IMC:
            var imc = CalcularImc(peso, altura);

            // Verifica se está em modo de adição
            if (indiceLinhaSelecionada == -1)
            {
                // Adicionar linha no dataGridView de pacientes
                dataGridView1.Rows.Add(new object[]
                {
                ++codigo, nome, altura, peso, imc
                });

                AdicionarPacienteSalvandoNoArquivo(codigo, nome, peso, altura);

                return;
            }

            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();

            EditarDados(nome, peso, altura);
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Obter a quantidade de linhas que o usuário selecionou no DataGridView
            var quantidadeLinhasSelecionadas = dataGridView1.SelectedRows.Count;

            if (quantidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione um paciente.");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            // Verifica se o usuário escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

                // Remove a linha utilizando o índice de DataGridView
                dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);

                // Remove o paciente da lista de pacientes
                pacientes.RemoveAt(indiceLinhaSelecionada);

                // Atualiza o arquivo com lista de pacientes sem o paciente removido
                SalvarEmArquivo();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente.");
                return;
            }

            // Obter a linha que o usuário selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter a infoemação da linha selecionada passando a coluna desejada
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }

        private void AdicionarPacienteSalvandoNoArquivo(int codigo, string nome, double peso, double altura)
        {
            //var paciente = new Paciente();
            //paciente.Codigo = codigo;
            //paciente.Nome = nome;
            //paciente.Peso = peso;
            //paciente.Altura = altura;

            var paciente = new Paciente
            {
                Codigo = codigo,
                Nome = nome,
                Peso = peso,
                Altura = altura
            };

            pacientes.Add(paciente);

            SalvarEmArquivo();
            LimparCampos();
        }

        private void EditarDados(string nome, double peso, double altura)
        {
            pacientes[indiceLinhaSelecionada].Nome = nome;
            pacientes[indiceLinhaSelecionada].Peso = peso;
            pacientes[indiceLinhaSelecionada].Altura = altura;

            SalvarEmArquivo();
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNome.Text = "";
            textBoxPeso.Text = "";
            textBoxAltura.Text = "";

            indiceLinhaSelecionada = -1;

            dataGridView1.ClearSelection();
        }

        private void SalvarEmArquivo()
        {

            // Converter uma lista de objetos em  uma string contendo o json
            var pacientesJson = JsonConvert.SerializeObject(pacientes);
            var caminho = "pacientes.json";
            // Salvar a string contendo o Json em um arquivo no formato json
            File.WriteAllText(caminho, pacientesJson);
        }

        private void LerArquivoApresentandoPacientes()
        {
            // Validar se arquivo não existe, consequentemente encerra o método, pois não há necessidade de percorrer o arquivo
            if (File.Exists("pacientes.json") == false)
                return;

            // Ler arquivo json e armazenar os pacientes na lista de pacientes
            var conteudoArquivo = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(conteudoArquivo);

            // Cria uma variável para armazenar p código do último paciente, para quando cadastrar um novo armazenar com o código correto
            var maiorCodigo = int.MinValue;

            // Percorre a lista de pacientes
            for (int i = 0; i < pacientes.Count; i++)
            {
                // Obtém o paciente que está sendo percorrido
                var paciente = pacientes[i];

                // Adiciona o paciente que estava no arquivo json no DataGridView
                dataGridView1.Rows.Add(new object[]
                {
                    paciente.Codigo, paciente.Nome, paciente.Altura, paciente.Peso, CalcularImc(paciente.Peso, paciente.Altura)
                });

                // Rotina para descobrir o paciente com o maior código
                if (paciente.Codigo > maiorCodigo)
                    maiorCodigo = paciente.Codigo;
            }

            // Validar se conseguiu encontrar algum código, caso contrário não deve atualizar o código dp novo produto
            if (maiorCodigo != int.MinValue)
                codigo = maiorCodigo;
        }

        private double CalcularImc(double peso, double altura)
        {
            // Math.Pow => exponencial
            return peso / Math.Pow(altura, 2);
        }
    }
}
