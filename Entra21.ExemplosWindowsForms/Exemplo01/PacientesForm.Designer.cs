namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    partial class PacientesForm
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
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelImc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(243, 15);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(82, 22);
            this.buttonEditar.TabIndex = 0;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(346, 15);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(82, 22);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(449, 54);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(449, 94);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(39, 15);
            this.labelAltura.TabIndex = 3;
            this.labelAltura.Text = "Altura";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(449, 71);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(241, 23);
            this.textBoxNome.TabIndex = 4;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(449, 151);
            this.textBoxPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(241, 23);
            this.textBoxPeso.TabIndex = 5;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(449, 111);
            this.textBoxAltura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(241, 23);
            this.textBoxAltura.TabIndex = 6;
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(449, 134);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(32, 15);
            this.labelPeso.TabIndex = 7;
            this.labelPeso.Text = "Peso";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(584, 185);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(106, 22);
            this.buttonSalvar.TabIndex = 8;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelImc
            // 
            this.labelImc.AutoSize = true;
            this.labelImc.Location = new System.Drawing.Point(449, 188);
            this.labelImc.Name = "labelImc";
            this.labelImc.Size = new System.Drawing.Size(29, 15);
            this.labelImc.TabIndex = 9;
            this.labelImc.Text = "IMC";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnAltura,
            this.ColumnPeso,
            this.ColumnImc});
            this.dataGridView1.Location = new System.Drawing.Point(10, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(417, 186);
            this.dataGridView1.TabIndex = 10;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 6;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 125;
            // 
            // ColumnAltura
            // 
            this.ColumnAltura.HeaderText = "Altura";
            this.ColumnAltura.MinimumWidth = 6;
            this.ColumnAltura.Name = "ColumnAltura";
            this.ColumnAltura.ReadOnly = true;
            this.ColumnAltura.Width = 125;
            // 
            // ColumnPeso
            // 
            this.ColumnPeso.HeaderText = "Peso";
            this.ColumnPeso.MinimumWidth = 6;
            this.ColumnPeso.Name = "ColumnPeso";
            this.ColumnPeso.ReadOnly = true;
            this.ColumnPeso.Width = 125;
            // 
            // ColumnImc
            // 
            this.ColumnImc.HeaderText = "IMC";
            this.ColumnImc.MinimumWidth = 6;
            this.ColumnImc.Name = "ColumnImc";
            this.ColumnImc.ReadOnly = true;
            this.ColumnImc.Width = 125;
            // 
            // PacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 360);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelImc);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PacientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pacientes";
            this.Load += new System.EventHandler(this.PacientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelNome;
        private Label labelAltura;
        private TextBox textBoxNome;
        private TextBox textBoxPeso;
        private TextBox textBoxAltura;
        private Label labelPeso;
        private Button buttonSalvar;
        private Label labelImc;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnAltura;
        private DataGridViewTextBoxColumn ColumnPeso;
        private DataGridViewTextBoxColumn ColumnImc;
    }
}