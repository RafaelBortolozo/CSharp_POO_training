using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("hello!");
            var pagamento = new Pagamento(); // no
            var pagamentoBoleto = new PagamentoBoleto(); //yes
            var pagamentoCartaoCredito = new PagamentoCartaoCredito(); //yes
            var pagamentoApplePay = new PagamentoApplePay(); //yes
        
        }
    }

    public abstract class Pagamento : IPagamento
    {
        public DateTime Vencimento { get; set; }

        public virtual void Pagar(double valor)
        {
            Console.WriteLine("Pagamento");
        }
    }

    public class PagamentoCartaoCredito : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }
    public class PagamentoBoleto : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    public class PagamentoApplePay : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    public interface IPagamento {
        DateTime Vencimento { get; set; }

        void Pagar(double valor);
    }
    
}
