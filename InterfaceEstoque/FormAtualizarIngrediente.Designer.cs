namespace InterfaceEstoque
{
    partial class FormAtualizarIngrediente
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
            this.voltar = new System.Windows.Forms.Button();
            this.labelQuantMax = new System.Windows.Forms.Label();
            this.labelQuantAtual = new System.Windows.Forms.Label();
            this.labelNomeIngrediente = new System.Windows.Forms.Label();
            this.textBoxQuantMax = new System.Windows.Forms.TextBox();
            this.textBoxQuantAtual = new System.Windows.Forms.TextBox();
            this.textBoxNomeIngrediente = new System.Windows.Forms.TextBox();
            this.tituloCadastrarIngrediente = new System.Windows.Forms.Label();
            this.atualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(198, 456);
            this.voltar.Margin = new System.Windows.Forms.Padding(4);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(100, 28);
            this.voltar.TabIndex = 17;
            this.voltar.Text = "VOLTAR";
            this.voltar.UseVisualStyleBackColor = true;
            // 
            // labelQuantMax
            // 
            this.labelQuantMax.AutoSize = true;
            this.labelQuantMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantMax.Location = new System.Drawing.Point(89, 261);
            this.labelQuantMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantMax.Name = "labelQuantMax";
            this.labelQuantMax.Size = new System.Drawing.Size(157, 20);
            this.labelQuantMax.TabIndex = 16;
            this.labelQuantMax.Text = "Quantidade Máxima";
            // 
            // labelQuantAtual
            // 
            this.labelQuantAtual.AutoSize = true;
            this.labelQuantAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantAtual.Location = new System.Drawing.Point(89, 186);
            this.labelQuantAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantAtual.Name = "labelQuantAtual";
            this.labelQuantAtual.Size = new System.Drawing.Size(135, 20);
            this.labelQuantAtual.TabIndex = 15;
            this.labelQuantAtual.Text = "Quantidade atual";
            // 
            // labelNomeIngrediente
            // 
            this.labelNomeIngrediente.AutoSize = true;
            this.labelNomeIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeIngrediente.Location = new System.Drawing.Point(89, 109);
            this.labelNomeIngrediente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeIngrediente.Name = "labelNomeIngrediente";
            this.labelNomeIngrediente.Size = new System.Drawing.Size(53, 20);
            this.labelNomeIngrediente.TabIndex = 14;
            this.labelNomeIngrediente.Text = "Nome";
            // 
            // textBoxQuantMax
            // 
            this.textBoxQuantMax.Location = new System.Drawing.Point(93, 285);
            this.textBoxQuantMax.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantMax.Name = "textBoxQuantMax";
            this.textBoxQuantMax.Size = new System.Drawing.Size(180, 22);
            this.textBoxQuantMax.TabIndex = 13;
            // 
            // textBoxQuantAtual
            // 
            this.textBoxQuantAtual.Location = new System.Drawing.Point(93, 210);
            this.textBoxQuantAtual.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantAtual.Name = "textBoxQuantAtual";
            this.textBoxQuantAtual.Size = new System.Drawing.Size(180, 22);
            this.textBoxQuantAtual.TabIndex = 12;
            // 
            // textBoxNomeIngrediente
            // 
            this.textBoxNomeIngrediente.Location = new System.Drawing.Point(93, 134);
            this.textBoxNomeIngrediente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomeIngrediente.Name = "textBoxNomeIngrediente";
            this.textBoxNomeIngrediente.Size = new System.Drawing.Size(308, 22);
            this.textBoxNomeIngrediente.TabIndex = 11;
            // 
            // tituloCadastrarIngrediente
            // 
            this.tituloCadastrarIngrediente.AutoSize = true;
            this.tituloCadastrarIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.tituloCadastrarIngrediente.Location = new System.Drawing.Point(70, 15);
            this.tituloCadastrarIngrediente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloCadastrarIngrediente.Name = "tituloCadastrarIngrediente";
            this.tituloCadastrarIngrediente.Size = new System.Drawing.Size(259, 25);
            this.tituloCadastrarIngrediente.TabIndex = 10;
            this.tituloCadastrarIngrediente.Text = "ATUALIZAR INGREDIENTE";
            this.tituloCadastrarIngrediente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // atualizar
            // 
            this.atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar.Location = new System.Drawing.Point(93, 375);
            this.atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(309, 50);
            this.atualizar.TabIndex = 9;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = true;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // FormAtualizarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 498);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.labelQuantMax);
            this.Controls.Add(this.labelQuantAtual);
            this.Controls.Add(this.labelNomeIngrediente);
            this.Controls.Add(this.textBoxQuantMax);
            this.Controls.Add(this.textBoxQuantAtual);
            this.Controls.Add(this.textBoxNomeIngrediente);
            this.Controls.Add(this.tituloCadastrarIngrediente);
            this.Controls.Add(this.atualizar);
            this.Name = "FormAtualizarIngrediente";
            this.Text = "FormAtualizarIngrediente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Label labelQuantMax;
        private System.Windows.Forms.Label labelQuantAtual;
        private System.Windows.Forms.Label labelNomeIngrediente;
        private System.Windows.Forms.TextBox textBoxQuantMax;
        private System.Windows.Forms.TextBox textBoxQuantAtual;
        private System.Windows.Forms.TextBox textBoxNomeIngrediente;
        private System.Windows.Forms.Label tituloCadastrarIngrediente;
        private System.Windows.Forms.Button atualizar;
    }
}