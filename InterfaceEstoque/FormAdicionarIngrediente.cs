using EstoquePizzaria;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace InterfaceEstoque
{
    public partial class FormAdicionarIngrediente : Form
    {
        Thread nt;
        private int id;
        private IFormaPagamento formaPagamentoStratgy;

        public FormAdicionarIngrediente(int id)
        {
            this.id = id;
            InitializeComponent();
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

        private void FormAdicionarIngrediente_Load(object sender, EventArgs e)
        {
            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {

                Ingrediente a = ctx.Ingrediente.Where(x => x.id_ingrediente == this.id).SingleOrDefault();

                labelNameIngrediente.Text = a.nome;
                labelQuantMax.Text = a.quant_max.ToString();

                numericUpDownIngrediente.Value = (decimal)a.quant_atual;
            }
        }



        private void buttonAdicionar_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
                {
                    Ingrediente a = ctx.Ingrediente.Where(x => x.id_ingrediente == this.id).SingleOrDefault();
                    a.quant_atual = (int)numericUpDownIngrediente.Value;

                    if (a.quant_atual > a.quant_max)
                    {
                        MessageBox.Show("Valor não pode execeder a quantidade máxima do ingrediente no estoque");
                        return;
                    }

                    ctx.SaveChanges();

                    string check = check_formaPagamento((int)a.quant_atual);
                    MessageBox.Show("Adicionado com sucesso!\n\nFORMA DE PAGAMENTO: " + check);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar!\n" + ex);
                throw;
            }

            this.Close();
            nt = new Thread(paginaGerenciarEstoque);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(paginaGerenciarEstoque);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void paginaGerenciarEstoque(object obj)
        {
            Application.Run(new FormGerenciarEstoque());
        }

    }
}
