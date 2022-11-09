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
using static System.Windows.Forms.LinkLabel;
using System.Runtime.Remoting.Messaging;

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

        public void atualizaGrid()
        {
            using (PizzariaDiegoEntities ctx = new PizzariaDiegoEntities())
            {
                dgvDados.DataSource = ctx.Ingrediente.ToList();
            }
        }

        private void addIngrediente_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(proximaPagina);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void removeIngrediente_Click(object sender, EventArgs e)
        {
            if (ehVazio()) { return; }
            try
            {
                int linha = Convert.ToInt16(dgvDados.CurrentRow.Index);

                int id = Int32.Parse(dgvDados.Rows[linha].Cells[0].Value.ToString());

                using (PizzariaDiegoEntities ctx = new PizzariaDiegoEntities())
                {
                    Ingrediente a = ctx.Ingrediente.Where(x => x.id_ingrediente == id).SingleOrDefault();

                    if (a != null)
                    {
                        ctx.Ingrediente.Remove(a);
                        ctx.SaveChanges();
                    }
                }
                MessageBox.Show("Item removido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover item!\n" + ex);
            }


            atualizaGrid();
        }

        private void attIngrediente_Click(object sender, EventArgs e)
        {
            if (ehVazio()) { return; }

            try
            {
                var formAtualizar = new FormAtualizarIngrediente();
                formAtualizar.ShowDialog(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar item\n" + ex);
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
            Application.Run(new FormAtualizarIngrediente());
        }

        private void esvaziarEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                using (PizzariaDiegoEntities ctx = new PizzariaDiegoEntities())
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao esvaziar estoque\n" + ex);
            }


        }

        private void completarEstoque_Click(object sender, EventArgs e)
        {
            if (ehVazio()) { return; }

            try
            {
                using (PizzariaDiegoEntities ctx = new PizzariaDiegoEntities())
                {
                    foreach (var item in ctx.Ingrediente)
                    {
                        Ingrediente a = item;
                        a.quant_atual = a.quant_max;
                        ctx.Entry(a).CurrentValues.SetValues(a);
                    }
                    ctx.SaveChanges();
                }
                atualizaGrid();
                MessageBox.Show("Estoque completado com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao completar estoque");
            }
        }

        private bool ehVazio()
        {
            if (dgvDados.Rows.Count == 0)
            {
                MessageBox.Show("Estoque Vazio!");
                return true;
            }
            return false;
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
