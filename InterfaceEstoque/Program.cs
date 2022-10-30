using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceEstoque
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }

        public static List<Ingredientes> AtualizarGrid()
        {
            CadastrarIngredienteEntities atualizarGrid = new CadastrarIngredienteEntities();
            return atualizarGrid.Ingredientes.ToList();
        }
    }
}
