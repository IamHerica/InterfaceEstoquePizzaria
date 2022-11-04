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
using System.Runtime.Remoting.Contexts;

namespace InterfaceEstoque
{
    public partial class FormGerenciarEstoque : Form
    {
        Thread nt;

        public FormGerenciarEstoque()
        {
            InitializeComponent();
        }

        private void FormGerenciarEstoque_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {
                dgvDados.DataSource = ctx.Ingrediente.ToList();
            }
        }

        private void addIngrediente_Click(object sender, EventArgs e)
        {

            Ingrediente a = new Ingrediente();
            a.id_ingrediente = 1;
            a.nome = "arroz";
            a.quant_atual = 1;
            a.quant_max = 5;

            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {
                ctx.Ingrediente.Add(a);
                ctx.SaveChanges();
            }

            atualizaGrid();
        }

        private void removeIngrediente_Click(object sender, EventArgs e)
        {
            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {
                Ingrediente a = ctx.Ingrediente.Where(x => x.id_ingrediente == 1).SingleOrDefault();

                if(a != null)
                {
                    ctx.Ingrediente.Remove(a);
                    ctx.SaveChanges();
                }
            }

            atualizaGrid();
        }

        private void attIngrediente_Click(object sender, EventArgs e)
        {
            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {
                Ingrediente a = ctx.Ingrediente.Where(x => x.id_ingrediente == 1).SingleOrDefault();

                if (a != null)
                {
                    a.nome = "alterado";
                    ctx.Entry(a).CurrentValues.SetValues(a);
                    ctx.SaveChanges();
                }
            }

            atualizaGrid();
        }

        private void cadastrarIngrediente_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(proximaPagina);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }


        private void proximaPagina(object obj)
        {
            Application.Run(new FormCadastrarIngrediente());
        }

        private void esvaziarEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
                {
                    foreach (var item in ctx.Ingrediente)
                    {
                        ctx.Ingrediente.Remove(item);
                    }
                    ctx.SaveChanges();
                }
                atualizaGrid();
                MessageBox.Show("Esvaziado com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao esvaziar estoque");
            }


        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(voltarPagina);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void voltarPagina(object obj)
        {
            Application.Run(new FormPrincipal());
        }
    }
}
