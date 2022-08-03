using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("hello!");
        
        }
    }

    public class Pagamento : IPagamento
    {
        public DateTime Vencimento { get; set; }

        public void Pagar(double valor)
        {
            Console.WriteLine("Pagamento");
        }
    }

    public interface IPagamento {
        DateTime Vencimento { get; set; }

        void Pagar(double valor);
    }
    
}
