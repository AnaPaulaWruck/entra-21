namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    partial class TipoPersonagemListagemForm
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.dataGridViewTiposPersonagens = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTiposPersonagens)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(125, 12);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(94, 29);
            this.buttonApagar.TabIndex = 0;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(234, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 29);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(343, 12);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(94, 29);
            this.buttonCadastrar.TabIndex = 2;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // dataGridViewTiposPersonagens
            // 
            this.dataGridViewTiposPersonagens.AllowUserToAddRows = false;
            this.dataGridViewTiposPersonagens.AllowUserToDeleteRows = false;
            this.dataGridViewTiposPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTiposPersonagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnTipo});
            this.dataGridViewTiposPersonagens.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewTiposPersonagens.Name = "dataGridViewTiposPersonagens";
            this.dataGridViewTiposPersonagens.ReadOnly = true;
            this.dataGridViewTiposPersonagens.RowHeadersWidth = 51;
            this.dataGridViewTiposPersonagens.RowTemplate.Height = 29;
            this.dataGridViewTiposPersonagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTiposPersonagens.Size = new System.Drawing.Size(425, 382);
            this.dataGridViewTiposPersonagens.TabIndex = 3;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 70;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo de Personagem";
            this.ColumnTipo.MinimumWidth = 6;
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.ReadOnly = true;
            this.ColumnTipo.Width = 300;
            // 
            // TipoPersonagemListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 446);
            this.Controls.Add(this.dataGridViewTiposPersonagens);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Name = "TipoPersonagemListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Personagens";
            this.Load += new System.EventHandler(this.TipoPersonagemListagemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTiposPersonagens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonCadastrar;
        private DataGridView dataGridViewTiposPersonagens;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnTipo;
    }
}