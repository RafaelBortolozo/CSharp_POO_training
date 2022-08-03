using System;

namespace Payments
{
    class Program
    {
        static void RealizarPagamento(double valor){
            Console.WriteLine($"Pago o valor de {valor}");
        }
        static void Main(string[] args){   
            var metodo = new Pagamento.Pagar(RealizarPagamento);
            metodo(25);
        }
    }

    public class Pagamento {
        public delegate void Pagar(double valor);
    }

}
