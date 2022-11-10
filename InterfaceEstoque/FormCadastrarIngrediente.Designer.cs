namespace InterfaceEstoque
{
    partial class FormCadastrarIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarIngrediente));
            this.cadastrar = new System.Windows.Forms.Button();
            this.tituloCadastrarIngrediente = new System.Windows.Forms.Label();
            this.textBoxNomeIngrediente = new System.Windows.Forms.TextBox();
            this.textBoxQuantAtual = new System.Windows.Forms.TextBox();
            this.textBoxQuantMax = new System.Windows.Forms.TextBox();
            this.labelNomeIngrediente = new System.Windows.Forms.Label();
            this.labelQuantAtual = new System.Windows.Forms.Label();
            this.labelQuantMax = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoButtom;
            this.cadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Location = new System.Drawing.Point(58, 370);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(232, 41);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // tituloCadastrarIngrediente
            // 
            this.tituloCadastrarIngrediente.AutoSize = true;
            this.tituloCadastrarIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.tituloCadastrarIngrediente.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloCadastrarIngrediente.ForeColor = System.Drawing.Color.Goldenrod;
            this.tituloCadastrarIngrediente.Location = new System.Drawing.Point(5, 111);
            this.tituloCadastrarIngrediente.Name = "tituloCadastrarIngrediente";
            this.tituloCadastrarIngrediente.Size = new System.Drawing.Size(343, 31);
            this.tituloCadastrarIngrediente.TabIndex = 1;
            this.tituloCadastrarIngrediente.Text = "CADASTRAR INGREDIENTE";
            this.tituloCadastrarIngrediente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNomeIngrediente
            // 
            this.textBoxNomeIngrediente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxNomeIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeIngrediente.Location = new System.Drawing.Point(58, 183);
            this.textBoxNomeIngrediente.Name = "textBoxNomeIngrediente";
            this.textBoxNomeIngrediente.Size = new System.Drawing.Size(232, 26);
            this.textBoxNomeIngrediente.TabIndex = 2;
            // 
            // textBoxQuantAtual
            // 
            this.textBoxQuantAtual.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxQuantAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantAtual.Location = new System.Drawing.Point(58, 245);
            this.textBoxQuantAtual.Name = "textBoxQuantAtual";
            this.textBoxQuantAtual.Size = new System.Drawing.Size(136, 26);
            this.textBoxQuantAtual.TabIndex = 3;
            // 
            // textBoxQuantMax
            // 
            this.textBoxQuantMax.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxQuantMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantMax.Location = new System.Drawing.Point(58, 306);
            this.textBoxQuantMax.Name = "textBoxQuantMax";
            this.textBoxQuantMax.Size = new System.Drawing.Size(136, 26);
            this.textBoxQuantMax.TabIndex = 4;
            // 
            // labelNomeIngrediente
            // 
            this.labelNomeIngrediente.AutoSize = true;
            this.labelNomeIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeIngrediente.ForeColor = System.Drawing.Color.Silver;
            this.labelNomeIngrediente.Location = new System.Drawing.Point(55, 163);
            this.labelNomeIngrediente.Name = "labelNomeIngrediente";
            this.labelNomeIngrediente.Size = new System.Drawing.Size(60, 20);
            this.labelNomeIngrediente.TabIndex = 5;
            this.labelNomeIngrediente.Text = "Nome:";
            // 
            // labelQuantAtual
            // 
            this.labelQuantAtual.AutoSize = true;
            this.labelQuantAtual.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantAtual.ForeColor = System.Drawing.Color.Silver;
            this.labelQuantAtual.Location = new System.Drawing.Point(55, 225);
            this.labelQuantAtual.Name = "labelQuantAtual";
            this.labelQuantAtual.Size = new System.Drawing.Size(152, 20);
            this.labelQuantAtual.TabIndex = 6;
            this.labelQuantAtual.Text = "Quantidade atual:";
            // 
            // labelQuantMax
            // 
            this.labelQuantMax.AutoSize = true;
            this.labelQuantMax.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantMax.ForeColor = System.Drawing.Color.Silver;
            this.labelQuantMax.Location = new System.Drawing.Point(55, 286);
            this.labelQuantMax.Name = "labelQuantMax";
            this.labelQuantMax.Size = new System.Drawing.Size(172, 20);
            this.labelQuantMax.TabIndex = 7;
            this.labelQuantMax.Text = "Quantidade Máxima:";
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.Firebrick;
            this.voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.Silver;
            this.voltar.Location = new System.Drawing.Point(137, 422);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 8;
            this.voltar.Text = "VOLTAR";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // FormCadastrarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoCadastroIngredientes2;
            this.ClientSize = new System.Drawing.Size(350, 474);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.labelQuantMax);
            this.Controls.Add(this.labelQuantAtual);
            this.Controls.Add(this.labelNomeIngrediente);
            this.Controls.Add(this.textBoxQuantMax);
            this.Controls.Add(this.textBoxQuantAtual);
            this.Controls.Add(this.textBoxNomeIngrediente);
            this.Controls.Add(this.tituloCadastrarIngrediente);
            this.Controls.Add(this.cadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastrarIngrediente";
            this.Text = "FormCadastrarIngrediente";
            this.Load += new System.EventHandler(this.FormCadastrarIngrediente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Label tituloCadastrarIngrediente;
        private System.Windows.Forms.TextBox textBoxNomeIngrediente;
        private System.Windows.Forms.TextBox textBoxQuantAtual;
        private System.Windows.Forms.TextBox textBoxQuantMax;
        private System.Windows.Forms.Label labelNomeIngrediente;
        private System.Windows.Forms.Label labelQuantAtual;
        private System.Windows.Forms.Label labelQuantMax;
        private System.Windows.Forms.Button voltar;
    }
}