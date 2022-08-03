using System;
using System.Data;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento(DateTime.Now);
            pagamento.Pagar("123456");
            
            Console.WriteLine("Hello!");
        }
    }


    public class Pagamento{

        public DateTime DataPagamento { get; set; }
        public Pagamento(DateTime vencimento){
            Console.WriteLine("Iniciando o pagamento");
            DataPagamento = DateTime.Now;
        }

        public virtual void Pagar(string numero) {
            Console.WriteLine("Pagar");
        }

    }

    public class PagamentoCartao : Pagamento{
        public override void Pagar(string numero) {
            base.Pagar(numero);
            Console.WriteLine("Pagar com cartão");
        }
    }

    public class Address{
        string ZipCode;
    }
}
