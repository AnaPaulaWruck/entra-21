namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    partial class UnidadeFederativaCadastroEdicaoForm
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelSigla = new System.Windows.Forms.Label();
            this.maskedTextBoxSigla = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(305, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(161, 98);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(242, 98);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelSigla
            // 
            this.labelSigla.AutoSize = true;
            this.labelSigla.Location = new System.Drawing.Point(12, 62);
            this.labelSigla.Name = "labelSigla";
            this.labelSigla.Size = new System.Drawing.Size(32, 15);
            this.labelSigla.TabIndex = 5;
            this.labelSigla.Text = "Sigla";
            // 
            // maskedTextBoxSigla
            // 
            this.maskedTextBoxSigla.Location = new System.Drawing.Point(50, 59);
            this.maskedTextBoxSigla.Mask = "LL";
            this.maskedTextBoxSigla.Name = "maskedTextBoxSigla";
            this.maskedTextBoxSigla.Size = new System.Drawing.Size(32, 23);
            this.maskedTextBoxSigla.TabIndex = 6;
            // 
            // UnidadeFederativaCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 133);
            this.Controls.Add(this.maskedTextBoxSigla);
            this.Controls.Add(this.labelSigla);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "UnidadeFederativaCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro/Edição Unidade Federativa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private Label labelNome;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label labelSigla;
        private MaskedTextBox maskedTextBoxSigla;
    }
}