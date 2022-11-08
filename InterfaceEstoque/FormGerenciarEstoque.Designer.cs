namespace InterfaceEstoque
{
    partial class FormGerenciarEstoque
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
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.addIngrediente = new System.Windows.Forms.Button();
            this.removeIngrediente = new System.Windows.Forms.Button();
            this.attIngrediente = new System.Windows.Forms.Button();
            this.cadastrarIngrediente = new System.Windows.Forms.Button();
            this.esvaziarEstoque = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.completarEstoque = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(116, 31);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(566, 236);
            this.dgvDados.TabIndex = 0;
            // 
            // addIngrediente
            // 
            this.addIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngrediente.Location = new System.Drawing.Point(116, 302);
            this.addIngrediente.Name = "addIngrediente";
            this.addIngrediente.Size = new System.Drawing.Size(164, 41);
            this.addIngrediente.TabIndex = 1;
            this.addIngrediente.Text = "Adicionar Ingrediente";
            this.addIngrediente.UseVisualStyleBackColor = true;
            this.addIngrediente.Click += new System.EventHandler(this.addIngrediente_Click);
            // 
            // removeIngrediente
            // 
            this.removeIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeIngrediente.Location = new System.Drawing.Point(320, 302);
            this.removeIngrediente.Name = "removeIngrediente";
            this.removeIngrediente.Size = new System.Drawing.Size(164, 41);
            this.removeIngrediente.TabIndex = 2;
            this.removeIngrediente.Text = "Remover Ingrediente";
            this.removeIngrediente.UseVisualStyleBackColor = true;
            this.removeIngrediente.Click += new System.EventHandler(this.removeIngrediente_Click);
            // 
            // attIngrediente
            // 
            this.attIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attIngrediente.Location = new System.Drawing.Point(518, 302);
            this.attIngrediente.Name = "attIngrediente";
            this.attIngrediente.Size = new System.Drawing.Size(164, 41);
            this.attIngrediente.TabIndex = 3;
            this.attIngrediente.Text = "Atualizar Ingrediente";
            this.attIngrediente.UseVisualStyleBackColor = true;
            this.attIngrediente.Click += new System.EventHandler(this.attIngrediente_Click);
            // 
            // cadastrarIngrediente
            // 
            this.cadastrarIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarIngrediente.Location = new System.Drawing.Point(116, 377);
            this.cadastrarIngrediente.Name = "cadastrarIngrediente";
            this.cadastrarIngrediente.Size = new System.Drawing.Size(164, 41);
            this.cadastrarIngrediente.TabIndex = 4;
            this.cadastrarIngrediente.Text = "Cadastrar Ingrediente";
            this.cadastrarIngrediente.UseVisualStyleBackColor = true;
            this.cadastrarIngrediente.Click += new System.EventHandler(this.cadastrarIngrediente_Click);
            // 
            // esvaziarEstoque
            // 
            this.esvaziarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esvaziarEstoque.Location = new System.Drawing.Point(320, 377);
            this.esvaziarEstoque.Name = "esvaziarEstoque";
            this.esvaziarEstoque.Size = new System.Drawing.Size(164, 41);
            this.esvaziarEstoque.TabIndex = 5;
            this.esvaziarEstoque.Text = "Esvaziar Estoque";
            this.esvaziarEstoque.UseVisualStyleBackColor = true;
            this.esvaziarEstoque.Click += new System.EventHandler(this.esvaziarEstoque_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(704, 31);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 6;
            this.buttonVoltar.Text = "VOLTAR";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // completarEstoque
            // 
            this.completarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completarEstoque.Location = new System.Drawing.Point(518, 377);
            this.completarEstoque.Name = "completarEstoque";
            this.completarEstoque.Size = new System.Drawing.Size(164, 41);
            this.completarEstoque.TabIndex = 7;
            this.completarEstoque.Text = "Completar Estoque";
            this.completarEstoque.UseVisualStyleBackColor = true;
            this.completarEstoque.Click += new System.EventHandler(this.completarEstoque_Click);
            // 
            // FormGerenciarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.completarEstoque);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.esvaziarEstoque);
            this.Controls.Add(this.cadastrarIngrediente);
            this.Controls.Add(this.attIngrediente);
            this.Controls.Add(this.removeIngrediente);
            this.Controls.Add(this.addIngrediente);
            this.Controls.Add(this.dgvDados);
            this.Name = "FormGerenciarEstoque";
            this.Text = "FormGerenciarEstoque";
            this.Load += new System.EventHandler(this.FormGerenciarEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button addIngrediente;
        private System.Windows.Forms.Button removeIngrediente;
        private System.Windows.Forms.Button attIngrediente;
        private System.Windows.Forms.Button cadastrarIngrediente;
        private System.Windows.Forms.Button esvaziarEstoque;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button completarEstoque;
    }
}