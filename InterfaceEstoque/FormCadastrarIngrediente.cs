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
using System.Threading;

namespace InterfaceEstoque
{
    public partial class FormCadastrarIngrediente : Form
    {
        Thread nt;

        public FormCadastrarIngrediente()
        {
            InitializeComponent();
        }

        private void FormCadastrarIngrediente_Load(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {

            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {
                Ingrediente ingrediente = new Ingrediente();
                try
                {
                    if ( ctx.Ingrediente.Count() == 0)
                    {
                        ingrediente.id_ingrediente = 1;
                    }
                    else
                    {
                        ingrediente.id_ingrediente = ctx.Ingrediente.Count()+1;
                    }
                    ingrediente.nome = textBoxNomeIngrediente.Text;
                    ingrediente.quant_atual = Int32.Parse(textBoxQuantAtual.Text);
                    ingrediente.quant_max = Int32.Parse(textBoxQuantMax.Text);

                    if (ingrediente.quant_max < ingrediente.quant_atual)
                    {
                        MessageBox.Show("Valor limite não pode ser abaixo do atual");
                        return;
                    }

                    ctx.Ingrediente.Add(ingrediente);
                    ctx.SaveChanges();

                    MessageBox.Show("Cadastrado com sucesso");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao cadastrar");
                }

                this.Close();
                nt = new Thread(proximaPagina);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        }
        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(voltarPagina);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void proximaPagina(object obj)
        {
            Application.Run(new FormGerenciarEstoque());
        }

        private void voltarPagina(object obj)
        {
            Application.Run(new FormGerenciarEstoque());
        }


    }
}
