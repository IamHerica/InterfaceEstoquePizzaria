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
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNameIngrediente = new System.Windows.Forms.Label();
            this.labelQuantMax = new System.Windows.Forms.Label();
            this.textBoxNameIngrediente = new System.Windows.Forms.TextBox();
            this.textBoxQuantMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(212, 299);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 0;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(448, 52);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 1;
            this.buttonVoltar.Text = "VOLTAR";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click_1);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(140, 35);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(144, 13);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "ATUALIZAR INGREDIENTE";
            // 
            // labelNameIngrediente
            // 
            this.labelNameIngrediente.AutoSize = true;
            this.labelNameIngrediente.Location = new System.Drawing.Point(95, 138);
            this.labelNameIngrediente.Name = "labelNameIngrediente";
            this.labelNameIngrediente.Size = new System.Drawing.Size(41, 13);
            this.labelNameIngrediente.TabIndex = 3;
            this.labelNameIngrediente.Text = "Nome: ";
            // 
            // labelQuantMax
            // 
            this.labelQuantMax.AutoSize = true;
            this.labelQuantMax.Location = new System.Drawing.Point(95, 181);
            this.labelQuantMax.Name = "labelQuantMax";
            this.labelQuantMax.Size = new System.Drawing.Size(100, 13);
            this.labelQuantMax.TabIndex = 4;
            this.labelQuantMax.Text = "Quantidade máxima";
            // 
            // textBoxNameIngrediente
            // 
            this.textBoxNameIngrediente.Location = new System.Drawing.Point(263, 135);
            this.textBoxNameIngrediente.Name = "textBoxNameIngrediente";
            this.textBoxNameIngrediente.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameIngrediente.TabIndex = 5;
            // 
            // textBoxQuantMax
            // 
            this.textBoxQuantMax.Location = new System.Drawing.Point(263, 178);
            this.textBoxQuantMax.Name = "textBoxQuantMax";
            this.textBoxQuantMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantMax.TabIndex = 6;
            // 
            // FormAtualizarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 369);
            this.Controls.Add(this.textBoxQuantMax);
            this.Controls.Add(this.textBoxNameIngrediente);
            this.Controls.Add(this.labelQuantMax);
            this.Controls.Add(this.labelNameIngrediente);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonAtualizar);
            this.Name = "FormAtualizarIngrediente";
            this.Text = "FormAtualizarIngrediente";
            this.Load += new System.EventHandler(this.FormAtualizarIngrediente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNameIngrediente;
        private System.Windows.Forms.Label labelQuantMax;
        private System.Windows.Forms.TextBox textBoxNameIngrediente;
        private System.Windows.Forms.TextBox textBoxQuantMax;
    }
}