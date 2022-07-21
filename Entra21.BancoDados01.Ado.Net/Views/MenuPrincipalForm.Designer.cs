namespace Entra21.BancoDados01.Ado.Net.Views
{
    partial class MenuPrincipalForm
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
            this.buttonEditoras = new System.Windows.Forms.Button();
            this.buttonPersonagens = new System.Windows.Forms.Button();
            this.buttonTiposPersonagens = new System.Windows.Forms.Button();
            this.buttonCidades = new System.Windows.Forms.Button();
            this.buttonUnidadesFederativas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditoras
            // 
            this.buttonEditoras.Location = new System.Drawing.Point(12, 12);
            this.buttonEditoras.Name = "buttonEditoras";
            this.buttonEditoras.Size = new System.Drawing.Size(120, 120);
            this.buttonEditoras.TabIndex = 0;
            this.buttonEditoras.Text = "EDITORAS";
            this.buttonEditoras.UseVisualStyleBackColor = true;
            this.buttonEditoras.Click += new System.EventHandler(this.buttonEditoras_Click);
            // 
            // buttonPersonagens
            // 
            this.buttonPersonagens.Location = new System.Drawing.Point(146, 12);
            this.buttonPersonagens.Name = "buttonPersonagens";
            this.buttonPersonagens.Size = new System.Drawing.Size(120, 120);
            this.buttonPersonagens.TabIndex = 1;
            this.buttonPersonagens.Text = "PERSONAGENS";
            this.buttonPersonagens.UseVisualStyleBackColor = true;
            this.buttonPersonagens.Click += new System.EventHandler(this.buttonPersonagens_Click);
            // 
            // buttonTiposPersonagens
            // 
            this.buttonTiposPersonagens.Location = new System.Drawing.Point(280, 12);
            this.buttonTiposPersonagens.Name = "buttonTiposPersonagens";
            this.buttonTiposPersonagens.Size = new System.Drawing.Size(120, 120);
            this.buttonTiposPersonagens.TabIndex = 2;
            this.buttonTiposPersonagens.Text = "TIPOS DE PERSONAGENS";
            this.buttonTiposPersonagens.UseVisualStyleBackColor = true;
            this.buttonTiposPersonagens.Click += new System.EventHandler(this.buttonTiposPersonagens_Click);
            // 
            // buttonCidades
            // 
            this.buttonCidades.Location = new System.Drawing.Point(77, 146);
            this.buttonCidades.Name = "buttonCidades";
            this.buttonCidades.Size = new System.Drawing.Size(120, 120);
            this.buttonCidades.TabIndex = 3;
            this.buttonCidades.Text = "CIDADES";
            this.buttonCidades.UseVisualStyleBackColor = true;
            this.buttonCidades.Click += new System.EventHandler(this.buttonCidades_Click);
            // 
            // buttonUnidadesFederativas
            // 
            this.buttonUnidadesFederativas.Location = new System.Drawing.Point(212, 146);
            this.buttonUnidadesFederativas.Name = "buttonUnidadesFederativas";
            this.buttonUnidadesFederativas.Size = new System.Drawing.Size(120, 120);
            this.buttonUnidadesFederativas.TabIndex = 4;
            this.buttonUnidadesFederativas.Text = "UNIDADES FEDERATIVAS";
            this.buttonUnidadesFederativas.UseVisualStyleBackColor = true;
            this.buttonUnidadesFederativas.Click += new System.EventHandler(this.buttonUnidadesFederativas_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 277);
            this.Controls.Add(this.buttonUnidadesFederativas);
            this.Controls.Add(this.buttonCidades);
            this.Controls.Add(this.buttonTiposPersonagens);
            this.Controls.Add(this.buttonPersonagens);
            this.Controls.Add(this.buttonEditoras);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEditoras;
        private Button buttonPersonagens;
        private Button buttonTiposPersonagens;
        private Button buttonCidades;
        private Button buttonUnidadesFederativas;
    }
}