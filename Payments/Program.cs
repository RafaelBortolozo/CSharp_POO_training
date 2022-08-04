using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Payments
{
    class Program
    {
        static void Main(string[] args){   
            Console.WriteLine("Hello");
            // PARTE 1
            // IEnumerable<Payment> payments = new List<Payment>();
            // IList<Payment> payments2 = new List<Payment>(); // mais métodos


            // PARTE 2
            // var payments = new List<Payment>();
            // payments.Add(new Payment(1));
            // payments.Add(new Payment(10));
            // payments.Add(new Payment(9));
            // payments.Add(new Payment(5));
            // payments.Add(new Payment(4));
            // payments.Add(new Payment(7));

            // foreach(var payment in payments){
            //     Console.WriteLine(payment.Id);
            // }

            // var paidPayments = new List<Payment>();
            // paidPayments.AddRange(payments); // concatena

            // var payment2 = payments.Where(x => x.Id > 5);
            // //var payment = payments.Firts(x => x.Id > 5); // Retorna um elemento

            // Tem um monte de metodos, melhor pesquisar na documentação.


            // PARTE 3
            IEnumerable<Payment> payments = new List<Payment>();
            payments.ToList();
            payments.AsEnumerable();
            payments.ToArray();
        }
    }

    public class Payment{
        public int Id { get; set; }
        public Payment(int id){
            Id = id;
        }

    }
}
