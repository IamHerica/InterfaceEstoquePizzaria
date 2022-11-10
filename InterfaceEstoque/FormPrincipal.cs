using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace InterfaceEstoque
{
    public partial class FormPrincipal : Form
    {
        Thread nt;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {
                if (ctx.Estoque.Count() != 0)
                {
                    if (ctx.Ingrediente.Count() == 0)
                    {
                        labelQuantAtual.Text = "0";
                        labelQuantMax.Text = "0%";
                        return;
                    }

                    Estoque estoque = ctx.Estoque.Where(x => x.id_estoque == 1).SingleOrDefault();
                    estoque.quant_ingredientes = 0;
                    estoque.limite_estoque = 0;

                    foreach (var item in ctx.Ingrediente)
                    {
                        estoque.quant_ingredientes = estoque.quant_ingredientes + item.quant_atual;
                        estoque.limite_estoque = estoque.limite_estoque + item.quant_max;
                    }

                    ctx.Entry(estoque).CurrentValues.SetValues(estoque);
                    ctx.SaveChanges();

                    labelQuantAtual.Text = estoque.quant_ingredientes.ToString();

                    try
                    {
                        labelQuantMax.Text = ((estoque.quant_ingredientes * 100) / (estoque.limite_estoque)).ToString() + "%";
                    }
                    catch (Exception)
                    {
                        labelQuantMax.Text = "0%";
                    }
                }
                else
                {
                    labelQuantAtual.Text = "n/a";
                    labelQuantMax.Text = "n/a";
                }
            }
        }


        private void buttonGerenciarEstoque_Click(object sender, EventArgs e)
        {
            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {
                try
                {
                    if (ctx.Estoque.Count() == 0)
                    {
                        MessageBox.Show("Estoque não foi criado!");
                        return;
                    }
                    else
                    {
                        this.Close();
                        nt = new Thread(proximaPagina);
                        nt.SetApartmentState(ApartmentState.STA);
                        nt.Start();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro\n" + ex);
                }
            }
        }

        private void proximaPagina(object obj)
        {
            Application.Run(new FormGerenciarEstoque());
        }

        private void buttonCriarEstoque_Click(object sender, EventArgs e)
        {
            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {

                Estoque estoque = new Estoque();
                try
                {

                    if (ctx.Estoque.Count() == 0)
                    {
                        estoque.id_estoque = 1;
                    }
                    else
                    {
                        MessageBox.Show("Estoque já criado!");
                        return;
                    }
                    estoque.nome = "Estoque 1";

                    ctx.Estoque.Add(estoque);
                    ctx.SaveChanges();

                    MessageBox.Show("Estoque criado com sucesso!");
                    FormPrincipal_Load(null, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar o estoque\n" + ex);
                }

            }
        }

        private void buttonDeletarEstoque_Click(object sender, EventArgs e)
        {
            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {

                Estoque estoque = new Estoque();
                try
                {

                    if (ctx.Estoque.Count() == 0)
                    {
                        MessageBox.Show("Estoque inexistente!");
                        return;
                    }
                    else
                    {
                        ctx.Database.ExecuteSqlCommand("TRUNCATE TABLE Estoque");
                        ctx.Database.ExecuteSqlCommand("TRUNCATE TABLE Ingrediente");
                    }

                    ctx.SaveChanges();


                    MessageBox.Show("Estoque deletado com sucesso!");
                    FormPrincipal_Load(null, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar o estoque\n" + ex);
                }

            }
        }

    }
}
