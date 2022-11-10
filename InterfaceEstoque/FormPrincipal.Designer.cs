namespace InterfaceEstoque
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.buttonCriarEstoque = new System.Windows.Forms.Button();
            this.buttonGerenciarEstoque = new System.Windows.Forms.Button();
            this.labelQuantAtual = new System.Windows.Forms.Label();
            this.labelQuantMax = new System.Windows.Forms.Label();
            this.labelTituloPrincipal = new System.Windows.Forms.Label();
            this.labelTextQuantAtual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeletarEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCriarEstoque
            // 
            this.buttonCriarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarEstoque.Location = new System.Drawing.Point(153, 372);
            this.buttonCriarEstoque.Name = "buttonCriarEstoque";
            this.buttonCriarEstoque.Size = new System.Drawing.Size(240, 52);
            this.buttonCriarEstoque.TabIndex = 17;
            this.buttonCriarEstoque.Text = "Criar Estoque";
            this.buttonCriarEstoque.UseVisualStyleBackColor = true;
            this.buttonCriarEstoque.Click += new System.EventHandler(this.buttonCriarEstoque_Click);
            // 
            // buttonGerenciarEstoque
            // 
            this.buttonGerenciarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerenciarEstoque.Location = new System.Drawing.Point(244, 314);
            this.buttonGerenciarEstoque.Name = "buttonGerenciarEstoque";
            this.buttonGerenciarEstoque.Size = new System.Drawing.Size(342, 52);
            this.buttonGerenciarEstoque.TabIndex = 23;
            this.buttonGerenciarEstoque.Text = "Gerenciar Estoque";
            this.buttonGerenciarEstoque.UseVisualStyleBackColor = true;
            this.buttonGerenciarEstoque.Click += new System.EventHandler(this.buttonGerenciarEstoque_Click);
            // 
            // labelQuantAtual
            // 
            this.labelQuantAtual.AutoSize = true;
            this.labelQuantAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantAtual.Location = new System.Drawing.Point(237, 133);
            this.labelQuantAtual.Name = "labelQuantAtual";
            this.labelQuantAtual.Padding = new System.Windows.Forms.Padding(8);
            this.labelQuantAtual.Size = new System.Drawing.Size(16, 53);
            this.labelQuantAtual.TabIndex = 24;
            // 
            // labelQuantMax
            // 
            this.labelQuantMax.AutoSize = true;
            this.labelQuantMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantMax.Location = new System.Drawing.Point(522, 133);
            this.labelQuantMax.Name = "labelQuantMax";
            this.labelQuantMax.Padding = new System.Windows.Forms.Padding(8);
            this.labelQuantMax.Size = new System.Drawing.Size(16, 53);
            this.labelQuantMax.TabIndex = 25;
            // 
            // labelTituloPrincipal
            // 
            this.labelTituloPrincipal.AutoSize = true;
            this.labelTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPrincipal.Location = new System.Drawing.Point(137, 30);
            this.labelTituloPrincipal.Name = "labelTituloPrincipal";
            this.labelTituloPrincipal.Size = new System.Drawing.Size(562, 46);
            this.labelTituloPrincipal.TabIndex = 28;
            this.labelTituloPrincipal.Text = "Controle de Estoque - Pizzaria";
            this.labelTituloPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTextQuantAtual
            // 
            this.labelTextQuantAtual.AutoSize = true;
            this.labelTextQuantAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextQuantAtual.Location = new System.Drawing.Point(140, 212);
            this.labelTextQuantAtual.Name = "labelTextQuantAtual";
            this.labelTextQuantAtual.Size = new System.Drawing.Size(253, 25);
            this.labelTextQuantAtual.TabIndex = 29;
            this.labelTextQuantAtual.Text = "Quantidade de Ingredientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Limite do Estoque %";
            // 
            // buttonDeletarEstoque
            // 
            this.buttonDeletarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletarEstoque.Location = new System.Drawing.Point(425, 372);
            this.buttonDeletarEstoque.Name = "buttonDeletarEstoque";
            this.buttonDeletarEstoque.Size = new System.Drawing.Size(240, 52);
            this.buttonDeletarEstoque.TabIndex = 31;
            this.buttonDeletarEstoque.Text = "Deletar Estoque";
            this.buttonDeletarEstoque.UseVisualStyleBackColor = true;
            this.buttonDeletarEstoque.Click += new System.EventHandler(this.buttonDeletarEstoque_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoPrincipal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeletarEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTextQuantAtual);
            this.Controls.Add(this.labelTituloPrincipal);
            this.Controls.Add(this.labelQuantMax);
            this.Controls.Add(this.labelQuantAtual);
            this.Controls.Add(this.buttonGerenciarEstoque);
            this.Controls.Add(this.buttonCriarEstoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCriarEstoque;
        private System.Windows.Forms.Button buttonGerenciarEstoque;
        private System.Windows.Forms.Label labelQuantAtual;
        private System.Windows.Forms.Label labelQuantMax;
        private System.Windows.Forms.Label labelTituloPrincipal;
        private System.Windows.Forms.Label labelTextQuantAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeletarEstoque;
    }
}

