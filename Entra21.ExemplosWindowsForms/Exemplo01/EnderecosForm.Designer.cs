namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    partial class EnderecosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEnderecos = new System.Windows.Forms.Label();
            this.dataGridViewEnderecos = new System.Windows.Forms.DataGridView();
            this.labelCep = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.labelEnderecoCompleto = new System.Windows.Forms.Label();
            this.textBoxEnderecoCompleto = new System.Windows.Forms.TextBox();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.labelMaskedTextBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnderecos
            // 
            this.labelEnderecos.AutoSize = true;
            this.labelEnderecos.Location = new System.Drawing.Point(12, 21);
            this.labelEnderecos.Name = "labelEnderecos";
            this.labelEnderecos.Size = new System.Drawing.Size(77, 20);
            this.labelEnderecos.TabIndex = 0;
            this.labelEnderecos.Text = "Endereços";
            // 
            // dataGridViewEnderecos
            // 
            this.dataGridViewEnderecos.AllowUserToAddRows = false;
            this.dataGridViewEnderecos.AllowUserToDeleteRows = false;
            this.dataGridViewEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnderecos.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewEnderecos.Name = "dataGridViewEnderecos";
            this.dataGridViewEnderecos.ReadOnly = true;
            this.dataGridViewEnderecos.RowHeadersWidth = 51;
            this.dataGridViewEnderecos.RowTemplate.Height = 29;
            this.dataGridViewEnderecos.Size = new System.Drawing.Size(588, 673);
            this.dataGridViewEnderecos.TabIndex = 1;
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(625, 32);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(34, 20);
            this.labelCep.TabIndex = 2;
            this.labelCep.Text = "CEP";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(625, 55);
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(141, 27);
            this.maskedTextBoxCep.TabIndex = 3;
            // 
            // labelEnderecoCompleto
            // 
            this.labelEnderecoCompleto.AutoSize = true;
            this.labelEnderecoCompleto.Location = new System.Drawing.Point(625, 94);
            this.labelEnderecoCompleto.Name = "labelEnderecoCompleto";
            this.labelEnderecoCompleto.Size = new System.Drawing.Size(141, 20);
            this.labelEnderecoCompleto.TabIndex = 4;
            this.labelEnderecoCompleto.Text = "Endereço Completo";
            // 
            // textBoxEnderecoCompleto
            // 
            this.textBoxEnderecoCompleto.Location = new System.Drawing.Point(625, 117);
            this.textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            this.textBoxEnderecoCompleto.Size = new System.Drawing.Size(328, 27);
            this.textBoxEnderecoCompleto.TabIndex = 5;
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(625, 158);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(64, 20);
            this.labelPaciente.TabIndex = 6;
            this.labelPaciente.Text = "Paciente";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(406, 17);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 29);
            this.buttonEditar.TabIndex = 7;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(506, 17);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(94, 29);
            this.buttonApagar.TabIndex = 8;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(750, 227);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(859, 227);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(625, 181);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(328, 28);
            this.comboBoxPaciente.TabIndex = 12;
            // 
            // labelMaskedTextBox
            // 
            this.labelMaskedTextBox.AutoSize = true;
            this.labelMaskedTextBox.Location = new System.Drawing.Point(772, 58);
            this.labelMaskedTextBox.Name = "labelMaskedTextBox";
            this.labelMaskedTextBox.Size = new System.Drawing.Size(112, 20);
            this.labelMaskedTextBox.TabIndex = 13;
            this.labelMaskedTextBox.Text = "MaskedTextBox";
            // 
            // EnderecosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 740);
            this.Controls.Add(this.labelMaskedTextBox);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelPaciente);
            this.Controls.Add(this.textBoxEnderecoCompleto);
            this.Controls.Add(this.labelEnderecoCompleto);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.dataGridViewEnderecos);
            this.Controls.Add(this.labelEnderecos);
            this.Name = "EnderecosForm";
            this.Text = "Cadastro de Endereços";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnderecos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEnderecos;
        private DataGridView dataGridViewEnderecos;
        private Label labelCep;
        private MaskedTextBox maskedTextBoxCep;
        private Label labelEnderecoCompleto;
        private TextBox textBoxEnderecoCompleto;
        private Label labelPaciente;
        private Button buttonEditar;
        private Button buttonApagar;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private ComboBox comboBoxPaciente;
        private Label labelMaskedTextBox;
    }
}