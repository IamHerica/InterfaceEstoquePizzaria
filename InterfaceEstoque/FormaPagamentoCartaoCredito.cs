using System;
using System.Collections.Generic;
using System.Text;

namespace EstoquePizzaria
{
    public class FormaPagamentoCartaoCredito : IFormaPagamento
    {
        public string formaPagamento()
        {
            return "Cartão de Crédito";
        }
    }
}
