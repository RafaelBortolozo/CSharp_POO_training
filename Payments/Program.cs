using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.NumeroBoleto = "123";

            var pagamento = new Pagamento();
            
        }
    }

    class Pagamento{
        public DateTime Vencimento;

        public virtual void Pagar(){ }

        public override string ToString()
        {
            return Vencimento.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }

    class PagamentoBoleto : Pagamento{
        public string NumeroBoleto;

        public override void Pagar()
        {
            base.Pagar();
        }
    }

    class PagamentoCartaoCredito : Pagamento{
        public string Numero;
    }
}
