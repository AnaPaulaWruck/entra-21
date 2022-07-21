namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    partial class UnidadeFederativaListagemForm
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
            this.dataGridViewUnidadesFederativas = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnidadesFederativas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUnidadesFederativas
            // 
            this.dataGridViewUnidadesFederativas.AllowUserToAddRows = false;
            this.dataGridViewUnidadesFederativas.AllowUserToDeleteRows = false;
            this.dataGridViewUnidadesFederativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnidadesFederativas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnSigla,
            this.ColumnNome});
            this.dataGridViewUnidadesFederativas.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewUnidadesFederativas.Name = "dataGridViewUnidadesFederativas";
            this.dataGridViewUnidadesFederativas.ReadOnly = true;
            this.dataGridViewUnidadesFederativas.RowTemplate.Height = 25;
            this.dataGridViewUnidadesFederativas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnidadesFederativas.Size = new System.Drawing.Size(384, 262);
            this.dataGridViewUnidadesFederativas.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 60;
            // 
            // ColumnSigla
            // 
            this.ColumnSigla.HeaderText = "Sigla";
            this.ColumnSigla.Name = "ColumnSigla";
            this.ColumnSigla.ReadOnly = true;
            this.ColumnSigla.Width = 60;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 220;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(158, 12);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(239, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(320, 12);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 3;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // UnidadeFederativaListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 315);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dataGridViewUnidadesFederativas);
            this.Name = "UnidadeFederativaListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidades Federativas";
            this.Load += new System.EventHandler(this.UnidadeFederativaListagemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnidadesFederativas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewUnidadesFederativas;
        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonCadastrar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnSigla;
        private DataGridViewTextBoxColumn ColumnNome;
    }
}