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
    public partial class FormPrincipal : Form
    {
        Thread nt;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            using (PizzariaDiegoEntities ctx = new PizzariaDiegoEntities())
            {

                var count_atual = 0;
                var count_max = 0;
                foreach (var item in ctx.Ingrediente)
                {
                    count_atual = count_atual + Convert.ToInt32(item.quant_atual);
                    count_max = count_max + Convert.ToInt32(item.quant_max);
                }
                labelQuantAtual.Text = count_atual.ToString();
                try
                {
                    labelQuantMax.Text = ((count_atual * 100) / (count_max)).ToString() + "%";
                }
                catch (Exception)
                {
                    labelQuantMax.Text = "0%";
                }
            }
        }


        private void buttonGerenciarEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(proximaPagina);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void proximaPagina(object obj)
        {
            Application.Run(new FormGerenciarEstoque());
        }

    }
}
