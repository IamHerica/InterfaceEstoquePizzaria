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
            this.cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Location = new System.Drawing.Point(71, 326);
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
            this.tituloCadastrarIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.tituloCadastrarIngrediente.Location = new System.Drawing.Point(54, 33);
            this.tituloCadastrarIngrediente.Name = "tituloCadastrarIngrediente";
            this.tituloCadastrarIngrediente.Size = new System.Drawing.Size(273, 25);
            this.tituloCadastrarIngrediente.TabIndex = 1;
            this.tituloCadastrarIngrediente.Text = "CADASTRAR INGREDIENTE";
            this.tituloCadastrarIngrediente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNomeIngrediente
            // 
            this.textBoxNomeIngrediente.Location = new System.Drawing.Point(71, 130);
            this.textBoxNomeIngrediente.Name = "textBoxNomeIngrediente";
            this.textBoxNomeIngrediente.Size = new System.Drawing.Size(232, 20);
            this.textBoxNomeIngrediente.TabIndex = 2;
            // 
            // textBoxQuantAtual
            // 
            this.textBoxQuantAtual.Location = new System.Drawing.Point(71, 192);
            this.textBoxQuantAtual.Name = "textBoxQuantAtual";
            this.textBoxQuantAtual.Size = new System.Drawing.Size(136, 20);
            this.textBoxQuantAtual.TabIndex = 3;
            // 
            // textBoxQuantMax
            // 
            this.textBoxQuantMax.Location = new System.Drawing.Point(71, 253);
            this.textBoxQuantMax.Name = "textBoxQuantMax";
            this.textBoxQuantMax.Size = new System.Drawing.Size(136, 20);
            this.textBoxQuantMax.TabIndex = 4;
            // 
            // labelNomeIngrediente
            // 
            this.labelNomeIngrediente.AutoSize = true;
            this.labelNomeIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeIngrediente.Location = new System.Drawing.Point(68, 110);
            this.labelNomeIngrediente.Name = "labelNomeIngrediente";
            this.labelNomeIngrediente.Size = new System.Drawing.Size(45, 17);
            this.labelNomeIngrediente.TabIndex = 5;
            this.labelNomeIngrediente.Text = "Nome";
            // 
            // labelQuantAtual
            // 
            this.labelQuantAtual.AutoSize = true;
            this.labelQuantAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantAtual.Location = new System.Drawing.Point(68, 172);
            this.labelQuantAtual.Name = "labelQuantAtual";
            this.labelQuantAtual.Size = new System.Drawing.Size(117, 17);
            this.labelQuantAtual.TabIndex = 6;
            this.labelQuantAtual.Text = "Quantidade atual";
            // 
            // labelQuantMax
            // 
            this.labelQuantMax.AutoSize = true;
            this.labelQuantMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantMax.Location = new System.Drawing.Point(68, 233);
            this.labelQuantMax.Name = "labelQuantMax";
            this.labelQuantMax.Size = new System.Drawing.Size(133, 17);
            this.labelQuantMax.TabIndex = 7;
            this.labelQuantMax.Text = "Quantidade Máxima";
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(150, 392);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 8;
            this.voltar.Text = "VOLTAR";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // FormCadastrarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 427);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.labelQuantMax);
            this.Controls.Add(this.labelQuantAtual);
            this.Controls.Add(this.labelNomeIngrediente);
            this.Controls.Add(this.textBoxQuantMax);
            this.Controls.Add(this.textBoxQuantAtual);
            this.Controls.Add(this.textBoxNomeIngrediente);
            this.Controls.Add(this.tituloCadastrarIngrediente);
            this.Controls.Add(this.cadastrar);
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