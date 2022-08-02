using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            pagamento.DataPagamento = DateTime.Now;
            
            Console.WriteLine("Hello!");
        }
    }


    public class Pagamento{
        public string NumeroBoleto;
        public DateTime Vencimento { get; set; }

        private DateTime _dataPagamento;
        public DateTime DataPagamento
        {
            get{ 
                Console.WriteLine("Lendo o valor");
                return _dataPagamento; 
            }
            set{ 
                Console.WriteLine("Atribuindo o valor");
                _dataPagamento = value; 
            }
        }
        

        void Pagar(){ }
    }
}
