using System;
using System.Collections.Generic;
using System.Text;

namespace EstoquePizzaria
{
    public class FormaPagamentoPix : IFormaPagamento
    {
        public string formaPagamento()
        {
            return "PIX";
        }
    }
}
