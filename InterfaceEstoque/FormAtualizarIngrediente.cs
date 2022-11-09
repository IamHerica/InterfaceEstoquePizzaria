using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceEstoque
{
    public partial class FormAtualizarIngrediente : Form
    {
        public FormAtualizarIngrediente()
        {
            InitializeComponent();
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            using (PizzariaDiegoEntities ctx = new PizzariaDiegoEntities())
            {
                Ingrediente ingrediente = new Ingrediente();
                try
                {
                    if (ctx.Ingrediente.Count() == 0)
                    {
                        ingrediente.id_ingrediente = 1;
                    }
                    else
                    {
                        short? maxId = (short)(from item in ctx.Ingrediente select item.id_ingrediente).Max();
                        ingrediente.id_ingrediente = (int)(maxId + 1);
                    }
                    ingrediente.nome = textBoxNomeIngrediente.Text;
                    ingrediente.quant_atual = Int32.Parse(textBoxQuantAtual.Text);
                    ingrediente.quant_max = Int32.Parse(textBoxQuantMax.Text);

                    if (ingrediente.quant_max < ingrediente.quant_atual)
                    {
                        MessageBox.Show("Valor limite não pode ser abaixo do atual");
                        return;
                    }

                    ctx.Entry(ingrediente).CurrentValues.SetValues(ingrediente);
                    ctx.SaveChanges();

                    MessageBox.Show("Atualizado com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar\n" + ex);
                }

                this.Close();
            }
        }
    }
}
