namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    partial class CidadeCadastroEdicaoForm
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelUnidadeFederativa = new System.Windows.Forms.Label();
            this.comboBoxUnidadeFederativa = new System.Windows.Forms.ComboBox();
            this.labelDataHoraFundacao = new System.Windows.Forms.Label();
            this.textBoxquantidadeHabitantes = new System.Windows.Forms.TextBox();
            this.labelQuantidadeHabitantes = new System.Windows.Forms.Label();
            this.dateTimePickerDataHoraFundacao = new System.Windows.Forms.DateTimePicker();
            this.labelPib = new System.Windows.Forms.Label();
            this.textBoxPib = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(258, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelUnidadeFederativa
            // 
            this.labelUnidadeFederativa.AutoSize = true;
            this.labelUnidadeFederativa.Location = new System.Drawing.Point(12, 64);
            this.labelUnidadeFederativa.Name = "labelUnidadeFederativa";
            this.labelUnidadeFederativa.Size = new System.Drawing.Size(108, 15);
            this.labelUnidadeFederativa.TabIndex = 2;
            this.labelUnidadeFederativa.Text = "Unidade Federativa";
            // 
            // comboBoxUnidadeFederativa
            // 
            this.comboBoxUnidadeFederativa.DisplayMember = "Sigla";
            this.comboBoxUnidadeFederativa.FormattingEnabled = true;
            this.comboBoxUnidadeFederativa.Location = new System.Drawing.Point(12, 82);
            this.comboBoxUnidadeFederativa.Name = "comboBoxUnidadeFederativa";
            this.comboBoxUnidadeFederativa.Size = new System.Drawing.Size(258, 23);
            this.comboBoxUnidadeFederativa.TabIndex = 3;
            // 
            // labelDataHoraFundacao
            // 
            this.labelDataHoraFundacao.AutoSize = true;
            this.labelDataHoraFundacao.Location = new System.Drawing.Point(12, 120);
            this.labelDataHoraFundacao.Name = "labelDataHoraFundacao";
            this.labelDataHoraFundacao.Size = new System.Drawing.Size(140, 15);
            this.labelDataHoraFundacao.TabIndex = 4;
            this.labelDataHoraFundacao.Text = "Data e Hora de Fundação";
            // 
            // textBoxquantidadeHabitantes
            // 
            this.textBoxquantidadeHabitantes.Location = new System.Drawing.Point(12, 194);
            this.textBoxquantidadeHabitantes.Name = "textBoxquantidadeHabitantes";
            this.textBoxquantidadeHabitantes.Size = new System.Drawing.Size(258, 23);
            this.textBoxquantidadeHabitantes.TabIndex = 5;
            // 
            // labelQuantidadeHabitantes
            // 
            this.labelQuantidadeHabitantes.AutoSize = true;
            this.labelQuantidadeHabitantes.Location = new System.Drawing.Point(12, 176);
            this.labelQuantidadeHabitantes.Name = "labelQuantidadeHabitantes";
            this.labelQuantidadeHabitantes.Size = new System.Drawing.Size(145, 15);
            this.labelQuantidadeHabitantes.TabIndex = 6;
            this.labelQuantidadeHabitantes.Text = "Quantidade de Habitantes";
            // 
            // dateTimePickerDataHoraFundacao
            // 
            this.dateTimePickerDataHoraFundacao.Location = new System.Drawing.Point(12, 138);
            this.dateTimePickerDataHoraFundacao.Name = "dateTimePickerDataHoraFundacao";
            this.dateTimePickerDataHoraFundacao.Size = new System.Drawing.Size(258, 23);
            this.dateTimePickerDataHoraFundacao.TabIndex = 7;
            // 
            // labelPib
            // 
            this.labelPib.AutoSize = true;
            this.labelPib.Location = new System.Drawing.Point(12, 231);
            this.labelPib.Name = "labelPib";
            this.labelPib.Size = new System.Drawing.Size(24, 15);
            this.labelPib.TabIndex = 8;
            this.labelPib.Text = "PIB";
            // 
            // textBoxPib
            // 
            this.textBoxPib.Location = new System.Drawing.Point(12, 249);
            this.textBoxPib.Name = "textBoxPib";
            this.textBoxPib.Size = new System.Drawing.Size(258, 23);
            this.textBoxPib.TabIndex = 9;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(114, 288);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(195, 288);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // CidadeCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 321);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxPib);
            this.Controls.Add(this.labelPib);
            this.Controls.Add(this.dateTimePickerDataHoraFundacao);
            this.Controls.Add(this.labelQuantidadeHabitantes);
            this.Controls.Add(this.textBoxquantidadeHabitantes);
            this.Controls.Add(this.labelDataHoraFundacao);
            this.Controls.Add(this.comboBoxUnidadeFederativa);
            this.Controls.Add(this.labelUnidadeFederativa);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "CidadeCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro/Edição Cidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelUnidadeFederativa;
        private ComboBox comboBoxUnidadeFederativa;
        private Label labelDataHoraFundacao;
        private TextBox textBoxquantidadeHabitantes;
        private Label labelQuantidadeHabitantes;
        private DateTimePicker dateTimePickerDataHoraFundacao;
        private Label labelPib;
        private TextBox textBoxPib;
        private Button buttonCancelar;
        private Button buttonSalvar;
    }
}