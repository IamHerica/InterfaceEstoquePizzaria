namespace InterfaceEstoque
{
    partial class FormAdicionarIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarIngrediente));
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNameIngrediente = new System.Windows.Forms.Label();
            this.numericUpDownIngrediente = new System.Windows.Forms.NumericUpDown();
            this.labelQuantMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIngrediente)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoButtom;
            this.buttonAdicionar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(207, 274);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(120, 42);
            this.buttonAdicionar.TabIndex = 0;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click_1);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(378, 30);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 1;
            this.buttonVoltar.Text = "VOLTAR";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTitulo.Location = new System.Drawing.Point(81, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(381, 37);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "ADICIONAR INGREDIENTE";
            // 
            // labelNameIngrediente
            // 
            this.labelNameIngrediente.AutoSize = true;
            this.labelNameIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.labelNameIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNameIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameIngrediente.ForeColor = System.Drawing.Color.Silver;
            this.labelNameIngrediente.Location = new System.Drawing.Point(181, 100);
            this.labelNameIngrediente.Name = "labelNameIngrediente";
            this.labelNameIngrediente.Size = new System.Drawing.Size(181, 26);
            this.labelNameIngrediente.TabIndex = 3;
            this.labelNameIngrediente.Text = "name_ingrediente";
            // 
            // numericUpDownIngrediente
            // 
            this.numericUpDownIngrediente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numericUpDownIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownIngrediente.Location = new System.Drawing.Point(210, 197);
            this.numericUpDownIngrediente.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownIngrediente.Name = "numericUpDownIngrediente";
            this.numericUpDownIngrediente.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownIngrediente.TabIndex = 4;
            // 
            // labelQuantMax
            // 
            this.labelQuantMax.AutoSize = true;
            this.labelQuantMax.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantMax.ForeColor = System.Drawing.Color.Silver;
            this.labelQuantMax.Location = new System.Drawing.Point(309, 150);
            this.labelQuantMax.Name = "labelQuantMax";
            this.labelQuantMax.Size = new System.Drawing.Size(97, 20);
            this.labelQuantMax.TabIndex = 5;
            this.labelQuantMax.Text = "quant_max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(136, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidade máxima: ";
            // 
            // FormAdicionarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceEstoque.Properties.Resources.fundoAttIngrediente;
            this.ClientSize = new System.Drawing.Size(474, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQuantMax);
            this.Controls.Add(this.numericUpDownIngrediente);
            this.Controls.Add(this.labelNameIngrediente);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonAdicionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdicionarIngrediente";
            this.Text = "AdicionarIngrediente";
            this.Load += new System.EventHandler(this.FormAdicionarIngrediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIngrediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNameIngrediente;
        private System.Windows.Forms.NumericUpDown numericUpDownIngrediente;
        private System.Windows.Forms.Label labelQuantMax;
        private System.Windows.Forms.Label label1;
    }
}