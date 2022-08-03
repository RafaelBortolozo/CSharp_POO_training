using System;
using System.Diagnostics.CodeAnalysis;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("hello!");
            // pessoaA == pessoaB => false
            var pessoaA = new Pessoa(1, "Rafael Bortolozo");
            var pessoaB = new Pessoa(1, "Rafael Bortolozo");

            Console.WriteLine(pessoaA.Equals(pessoaB));

        }
    }

    public class Pessoa : IEquatable<Pessoa>{
        public Pessoa(int id, string nome){
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set;}

        public bool Equals(Pessoa other)
        {
            return Id == other.Id;
        }
    }  

}
