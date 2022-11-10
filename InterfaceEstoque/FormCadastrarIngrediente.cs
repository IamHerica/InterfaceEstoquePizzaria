using EstoquePizzaria;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace InterfaceEstoque
{
    public partial class FormCadastrarIngrediente : Form
    {
        Thread nt;
        private IFormaPagamento formaPagamentoStratgy;

        public FormCadastrarIngrediente()
        {
            InitializeComponent();
        }

        private void FormCadastrarIngrediente_Load(object sender, EventArgs e)
        {

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

        private void cadastrar_Click(object sender, EventArgs e)
        {

            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
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
                        System.Nullable<Int16> maxId = (short)(from item in ctx.Ingrediente select item.id_ingrediente).Max();
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

                    ctx.Ingrediente.Add(ingrediente);
                    ctx.SaveChanges();

                    string check = check_formaPagamento((int)ingrediente.quant_atual);
                    MessageBox.Show("Cadastrado com sucesso\n\nFORMA DE PAGAMENTO: " + check);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar\n" + ex);
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
