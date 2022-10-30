using System;
using System.Windows.Forms;

namespace InterfaceEstoque
{
    public partial class FormAdicionarIngrediente : Form
    {
        public FormAdicionarIngrediente()
        {
            InitializeComponent();
        }

        private void FormAdicionarIngrediente_Load(object sender, EventArgs e)
        {
                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ingrediente = new Ingredientes(textBox1.Text, int.Parse(numericUpDown1.Text));
            using (CadastrarIngredienteEntities encherEstoque = new CadastrarIngredienteEntities())
            {
                encherEstoque.Ingredientes.Add(ingrediente);
                encherEstoque.SaveChanges();

            }
            Program.AtualizarGrid();
        }
    }
}
