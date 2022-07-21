namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    partial class CidadeListagemForm
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
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dataGridViewCidades = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnidadeFederativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataHoraFundacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeHabitantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(586, 12);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 0;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(669, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(752, 12);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCidades
            // 
            this.dataGridViewCidades.AllowUserToAddRows = false;
            this.dataGridViewCidades.AllowUserToDeleteRows = false;
            this.dataGridViewCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnUnidadeFederativa,
            this.ColumnDataHoraFundacao,
            this.ColumnQuantidadeHabitantes,
            this.ColumnPib});
            this.dataGridViewCidades.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewCidades.Name = "dataGridViewCidades";
            this.dataGridViewCidades.ReadOnly = true;
            this.dataGridViewCidades.RowTemplate.Height = 25;
            this.dataGridViewCidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCidades.Size = new System.Drawing.Size(815, 397);
            this.dataGridViewCidades.TabIndex = 3;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 60;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 220;
            // 
            // ColumnUnidadeFederativa
            // 
            this.ColumnUnidadeFederativa.HeaderText = "UF";
            this.ColumnUnidadeFederativa.Name = "ColumnUnidadeFederativa";
            this.ColumnUnidadeFederativa.ReadOnly = true;
            this.ColumnUnidadeFederativa.Width = 40;
            // 
            // ColumnDataHoraFundacao
            // 
            this.ColumnDataHoraFundacao.HeaderText = "Data/Hora Fundação";
            this.ColumnDataHoraFundacao.Name = "ColumnDataHoraFundacao";
            this.ColumnDataHoraFundacao.ReadOnly = true;
            this.ColumnDataHoraFundacao.Width = 150;
            // 
            // ColumnQuantidadeHabitantes
            // 
            this.ColumnQuantidadeHabitantes.HeaderText = "Quant. Habitantes";
            this.ColumnQuantidadeHabitantes.Name = "ColumnQuantidadeHabitantes";
            this.ColumnQuantidadeHabitantes.ReadOnly = true;
            this.ColumnQuantidadeHabitantes.Width = 150;
            // 
            // ColumnPib
            // 
            this.ColumnPib.HeaderText = "PIB";
            this.ColumnPib.Name = "ColumnPib";
            this.ColumnPib.ReadOnly = true;
            this.ColumnPib.Width = 150;
            // 
            // CidadeListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.dataGridViewCidades);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Name = "CidadeListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cidades";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonSalvar;
        private DataGridView dataGridViewCidades;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnUnidadeFederativa;
        private DataGridViewTextBoxColumn ColumnDataHoraFundacao;
        private DataGridViewTextBoxColumn ColumnQuantidadeHabitantes;
        private DataGridViewTextBoxColumn ColumnPib;
    }
}