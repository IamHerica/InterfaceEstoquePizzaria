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
            this.tituloAtualizarIngrediente = new System.Windows.Forms.Label();
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
            this.cadastrar.Location = new System.Drawing.Point(95, 401);
            this.cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(309, 50);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // tituloAtualizarIngrediente
            // 
            this.tituloAtualizarIngrediente.AutoSize = true;
            this.tituloAtualizarIngrediente.CausesValidation = false;
            this.tituloAtualizarIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.tituloAtualizarIngrediente.Location = new System.Drawing.Point(72, 41);
            this.tituloAtualizarIngrediente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloAtualizarIngrediente.Name = "tituloAtualizarIngrediente";
            this.tituloAtualizarIngrediente.Size = new System.Drawing.Size(341, 31);
            this.tituloAtualizarIngrediente.TabIndex = 1;
            this.tituloAtualizarIngrediente.Text = "CADASTRAR INGREDIENTE";
            this.tituloAtualizarIngrediente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNomeIngrediente
            // 
            this.textBoxNomeIngrediente.Location = new System.Drawing.Point(95, 160);
            this.textBoxNomeIngrediente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomeIngrediente.Name = "textBoxNomeIngrediente";
            this.textBoxNomeIngrediente.Size = new System.Drawing.Size(308, 22);
            this.textBoxNomeIngrediente.TabIndex = 2;
            // 
            // textBoxQuantAtual
            // 
            this.textBoxQuantAtual.Location = new System.Drawing.Point(95, 236);
            this.textBoxQuantAtual.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantAtual.Name = "textBoxQuantAtual";
            this.textBoxQuantAtual.Size = new System.Drawing.Size(180, 22);
            this.textBoxQuantAtual.TabIndex = 3;
            // 
            // textBoxQuantMax
            // 
            this.textBoxQuantMax.Location = new System.Drawing.Point(95, 311);
            this.textBoxQuantMax.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantMax.Name = "textBoxQuantMax";
            this.textBoxQuantMax.Size = new System.Drawing.Size(180, 22);
            this.textBoxQuantMax.TabIndex = 4;
            // 
            // labelNomeIngrediente
            // 
            this.labelNomeIngrediente.AutoSize = true;
            this.labelNomeIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeIngrediente.Location = new System.Drawing.Point(91, 135);
            this.labelNomeIngrediente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeIngrediente.Name = "labelNomeIngrediente";
            this.labelNomeIngrediente.Size = new System.Drawing.Size(53, 20);
            this.labelNomeIngrediente.TabIndex = 5;
            this.labelNomeIngrediente.Text = "Nome";
            // 
            // labelQuantAtual
            // 
            this.labelQuantAtual.AutoSize = true;
            this.labelQuantAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantAtual.Location = new System.Drawing.Point(91, 212);
            this.labelQuantAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantAtual.Name = "labelQuantAtual";
            this.labelQuantAtual.Size = new System.Drawing.Size(135, 20);
            this.labelQuantAtual.TabIndex = 6;
            this.labelQuantAtual.Text = "Quantidade atual";
            // 
            // labelQuantMax
            // 
            this.labelQuantMax.AutoSize = true;
            this.labelQuantMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantMax.Location = new System.Drawing.Point(91, 287);
            this.labelQuantMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantMax.Name = "labelQuantMax";
            this.labelQuantMax.Size = new System.Drawing.Size(157, 20);
            this.labelQuantMax.TabIndex = 7;
            this.labelQuantMax.Text = "Quantidade Máxima";
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(200, 482);
            this.voltar.Margin = new System.Windows.Forms.Padding(4);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(100, 28);
            this.voltar.TabIndex = 8;
            this.voltar.Text = "VOLTAR";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // FormCadastrarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 526);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.labelQuantMax);
            this.Controls.Add(this.labelQuantAtual);
            this.Controls.Add(this.labelNomeIngrediente);
            this.Controls.Add(this.textBoxQuantMax);
            this.Controls.Add(this.textBoxQuantAtual);
            this.Controls.Add(this.textBoxNomeIngrediente);
            this.Controls.Add(this.tituloAtualizarIngrediente);
            this.Controls.Add(this.cadastrar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadastrarIngrediente";
            this.Text = "FormCadastrarIngrediente";
            this.Load += new System.EventHandler(this.FormCadastrarIngrediente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Label tituloAtualizarIngrediente;
        private System.Windows.Forms.TextBox textBoxNomeIngrediente;
        private System.Windows.Forms.TextBox textBoxQuantAtual;
        private System.Windows.Forms.TextBox textBoxQuantMax;
        private System.Windows.Forms.Label labelNomeIngrediente;
        private System.Windows.Forms.Label labelQuantAtual;
        private System.Windows.Forms.Label labelQuantMax;
        private System.Windows.Forms.Button voltar;
    }
}