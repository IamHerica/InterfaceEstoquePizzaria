using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace InterfaceEstoque
{
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
            dataGridView1.DataSource = Program.AtualizarGrid();
        }

        List<Ingredientes> Estoque = new List<Ingredientes>();

        private void button2_Click(object sender, EventArgs e)
        {
            using (CadastrarIngredienteEntities excluirIngrediente = new CadastrarIngredienteEntities())
            {
                var tamanho = Estoque.Count;
                for (int i = 0; i < tamanho; i++)
                {
                    //excluirIngrediente.Ingredientes.Remove(Estoque.IndexOf(i));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mussarela = new Ingredientes("Mussarela", 50);
            var presunto = new Ingredientes("Presunto", 50);
            var azeitona = new Ingredientes("Azeitona (Pote)", 5);
            var palmito = new Ingredientes("Palmito (pote)", 5);
            var ovos = new Ingredientes("Ovos(Duzia", 5);
            var molhoDeTomate = new Ingredientes("Molho de tomate", 50);
            var brocolis = new Ingredientes("Brocolis (caixa)", 5);
            var frango = new Ingredientes("Frango desfiado(Pacote)", 5);
            var bacon = new Ingredientes("Bacon(Pacote)", 5);


            using (CadastrarIngredienteEntities encherEstoque = new CadastrarIngredienteEntities())
            {
                encherEstoque.Ingredientes.Add(mussarela);
                encherEstoque.Ingredientes.Add(presunto);
                encherEstoque.Ingredientes.Add(azeitona);
                encherEstoque.Ingredientes.Add(palmito);
                encherEstoque.Ingredientes.Add(ovos);
                encherEstoque.Ingredientes.Add(molhoDeTomate);
                encherEstoque.Ingredientes.Add(brocolis);
                encherEstoque.Ingredientes.Add(frango);
                encherEstoque.Ingredientes.Add(bacon);
                encherEstoque.SaveChangesAsync();

            }
            dataGridView1.DataSource = Program.AtualizarGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAdicionarIngrediente formAdicionarIngrediente = new FormAdicionarIngrediente();
            formAdicionarIngrediente.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
    }
}
