using EstoquePizzaria;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace InterfaceEstoque
{
    public partial class FormGerenciarEstoque : Form
    {
        Thread nt;
        private IFormaPagamento formaPagamentoStratgy;

        public FormGerenciarEstoque()
        {
            InitializeComponent();
        }

        private void FormGerenciarEstoque_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        /* ****** BOTÃO PARA ADICIONAR UM INGREDIENTE ***** */
        private void buttonAddIngrediente_Click(object sender, EventArgs e)
        {
            if (ehVazio()) { return; }

            int linha = Convert.ToInt16(dgvDados.CurrentRow.Index);
            int id = Int32.Parse(dgvDados.Rows[linha].Cells[0].Value.ToString());
            ponteiroDVG.ID = id;

            this.Close();
            nt = new Thread(paginaADDIngrediente);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        /* ****** BOTÃO PARA REMOVER UM INGREDIENTE ***** */
        private void buttonRemoveIngrediente_Click(object sender, EventArgs e)
        {
            if (ehVazio()) { return; }

            try
            {
                int linha = Convert.ToInt16(dgvDados.CurrentRow.Index);
                int id = Int32.Parse(dgvDados.Rows[linha].Cells[0].Value.ToString());

                using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
                {
                    Ingrediente a = ctx.Ingrediente.Where(x => x.id_ingrediente == id).SingleOrDefault();

                    if (a != null)
                    {
                        ctx.Ingrediente.Remove(a);
                        ctx.SaveChanges();
                    }
                }
                atualizaGrid();
                MessageBox.Show("Item removido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover item!\n" + ex);
            }

        }

        /* ****** BOTÃO PARA ATUALIZAR UM INGREDIENTE ***** */
        private void buttonAttIngrediente_Click(object sender, EventArgs e)
        {
            if (ehVazio()) { return; }

            int linha = Convert.ToInt16(dgvDados.CurrentRow.Index);
            int id = Int32.Parse(dgvDados.Rows[linha].Cells[0].Value.ToString());
            ponteiroDVG.ID = id;

            this.Close();
            nt = new Thread(paginaATTIngrediente);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        /* ****** BOTÃO PARA CADASTRAR UM INGREDIENTE ***** */
        private void buttonCadastrarIngrediente_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(paginaCadastrarIngrediente);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        /* ****** BOTÃO PARA ESVAZIAR TODO O ESTOQUE ***** */
        private void buttonEsvaziarEstoque_Click(object sender, EventArgs e)
        {
            if (ehVazio()) { return; }

            try
            {
                using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
                {
                    ctx.Database.ExecuteSqlCommand("TRUNCATE TABLE Ingrediente");
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

        /* ****** BOTÃO PARA COMPLETAR TODO O ESTOQUE ***** */
        private void buttonCompletarEstoque_Click(object sender, EventArgs e)
        {
            if (ehVazio()) { return; }

            try
            {
                var count = 0;
                using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
                {
                    foreach (var item in ctx.Ingrediente)
                    {
                        Ingrediente a = item;
                        a.quant_atual = a.quant_max;
                        count += (int)a.quant_max - (int)a.quant_atual;
                        ctx.Entry(a).CurrentValues.SetValues(a);
                    }
                    ctx.SaveChanges();
                }
                atualizaGrid();
                string check = check_formaPagamento(count);
                MessageBox.Show("Estoque completado com sucesso\n\nFORMA DE PAGAMENTO: " + check);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao completar estoque");
            }
        }

        /* ****** BOTÃO PARA VOLTAR A PAGINA PRINCIPAL ***** */
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(paginaPrincipal);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        /* ****** FUNÇÃO PARA VERIFICAR SE O ESTOQUE ESTÁ VAZIO ***** */
        private bool ehVazio()
        {
            if (dgvDados.Rows.Count == 0)
            {
                MessageBox.Show("Estoque Vazio!");
                return true;
            }
            return false;
        }

        public string check_formaPagamento(int qtd) //Strategy definir forma de pagamento
        {
            if (qtd < 10)
            {
                formaPagamentoStratgy = new FormaPagamentoPix();
                return formaPagamentoStratgy.formaPagamento();
            }

            formaPagamentoStratgy = new FormaPagamentoCartaoCredito();
            return formaPagamentoStratgy.formaPagamento();
        }

        /* ****** FUNÇÃO PARA ATUALIZAR O DGV ***** */
        private void atualizaGrid()
        {
            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {
                dgvDados.DataSource = ctx.Ingrediente.ToList();
            }
        }

        /* ****** FUNÇÃO PARA ABRIR A TELA PRINCIPAL ***** */
        private void paginaPrincipal(object obj)
        {
            Application.Run(new FormPrincipal());
        }

        /* ****** FUNÇÃO PARA ABRIR A TELA CADASTRAR INGREDIENTE ***** */
        private void paginaCadastrarIngrediente(object obj)
        {
            Application.Run(new FormCadastrarIngrediente());
        }

        /* ****** FUNÇÃO PARA ABRIR A TELA ADICIONAR INGREDIENTE ***** */
        private void paginaADDIngrediente(object obj)
        {
            Application.Run(new FormAdicionarIngrediente(ponteiroDVG.ID));
        }

        /* ****** FUNÇÃO PARA ABRIR A TELA ATUALIZAR INGREDIENTE ***** */
        private void paginaATTIngrediente(object obj)
        {
            Application.Run(new FormAtualizarIngrediente(ponteiroDVG.ID));
        }

        /* ****** CLASSE PARA GUARDA O ID DE UM INGREDIENTE ***** */
        public static class ponteiroDVG
        {
            public static int ID;
        }
    }
}
