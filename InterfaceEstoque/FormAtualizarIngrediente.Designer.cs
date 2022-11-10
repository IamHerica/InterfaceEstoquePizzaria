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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtualizarIngrediente));
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
            this.buttonAtualizar.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoButtom;
            this.buttonAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Location = new System.Drawing.Point(252, 272);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(113, 42);
            this.buttonAtualizar.TabIndex = 0;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.Color.Silver;
            this.buttonVoltar.Location = new System.Drawing.Point(272, 320);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 1;
            this.buttonVoltar.Text = "VOLTAR";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click_1);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTitulo.Location = new System.Drawing.Point(141, 42);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(361, 33);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "ATUALIZAR INGREDIENTE";
            // 
            // labelNameIngrediente
            // 
            this.labelNameIngrediente.AutoSize = true;
            this.labelNameIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.labelNameIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameIngrediente.ForeColor = System.Drawing.Color.Silver;
            this.labelNameIngrediente.Location = new System.Drawing.Point(154, 141);
            this.labelNameIngrediente.Name = "labelNameIngrediente";
            this.labelNameIngrediente.Size = new System.Drawing.Size(65, 20);
            this.labelNameIngrediente.TabIndex = 3;
            this.labelNameIngrediente.Text = "Nome: ";
            // 
            // labelQuantMax
            // 
            this.labelQuantMax.AutoSize = true;
            this.labelQuantMax.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantMax.ForeColor = System.Drawing.Color.Silver;
            this.labelQuantMax.Location = new System.Drawing.Point(154, 186);
            this.labelQuantMax.Name = "labelQuantMax";
            this.labelQuantMax.Size = new System.Drawing.Size(172, 20);
            this.labelQuantMax.TabIndex = 4;
            this.labelQuantMax.Text = "Quantidade máxima:";
            // 
            // textBoxNameIngrediente
            // 
            this.textBoxNameIngrediente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxNameIngrediente.Location = new System.Drawing.Point(332, 143);
            this.textBoxNameIngrediente.Name = "textBoxNameIngrediente";
            this.textBoxNameIngrediente.Size = new System.Drawing.Size(155, 20);
            this.textBoxNameIngrediente.TabIndex = 5;
            // 
            // textBoxQuantMax
            // 
            this.textBoxQuantMax.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxQuantMax.Location = new System.Drawing.Point(332, 188);
            this.textBoxQuantMax.Name = "textBoxQuantMax";
            this.textBoxQuantMax.Size = new System.Drawing.Size(155, 20);
            this.textBoxQuantMax.TabIndex = 6;
            // 
            // FormAtualizarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoAttIngrediente;
            this.ClientSize = new System.Drawing.Size(542, 375);
            this.Controls.Add(this.textBoxQuantMax);
            this.Controls.Add(this.textBoxNameIngrediente);
            this.Controls.Add(this.labelQuantMax);
            this.Controls.Add(this.labelNameIngrediente);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonAtualizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAtualizarIngrediente";
            this.Text = "AtualizarIngrediente";
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