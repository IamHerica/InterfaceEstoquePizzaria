using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace InterfaceEstoque
{
    public partial class FormAtualizarIngrediente : Form
    {
        Thread nt;
        int id;
        public FormAtualizarIngrediente(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FormAtualizarIngrediente_Load(object sender, EventArgs e)
        {
            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {
                Ingrediente a = ctx.Ingrediente.Where(x => x.id_ingrediente == this.id).SingleOrDefault();

                textBoxNameIngrediente.Text = a.nome;
                textBoxQuantMax.Text = a.quant_max.ToString();
            }

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {
                try
                {
                    Ingrediente a = ctx.Ingrediente.Where(x => x.id_ingrediente == this.id).SingleOrDefault();

                    a.nome = textBoxNameIngrediente.Text;
                    a.quant_max = Int32.Parse(textBoxQuantMax.Text);

                    if (Int32.Parse(textBoxQuantMax.Text) < a.quant_atual)
                    {
                        MessageBox.Show("Valor máximo não pode estar abaixo da quantidade atual\nQuantidade atual: " + a.quant_atual);
                        return;
                    }

                    ctx.Entry(a).CurrentValues.SetValues(a);
                    ctx.SaveChanges();
                    MessageBox.Show("Atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar!\n" + ex);
                }

                this.Close();
                nt = new Thread(paginaGerenciarEstoque);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        }

        private void voltarPagina(object obj)
        {
            Application.Run(new FormGerenciarEstoque());
        }

        private void paginaGerenciarEstoque(object obj)
        {
            Application.Run(new FormGerenciarEstoque());
        }

        private void buttonVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(voltarPagina);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
    }
}
