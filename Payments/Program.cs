using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args){   
            Console.WriteLine("Hello");
            var context = new DataContext<IPerson, Payment, Subscription>();
            context.Save(new Payment());
            context.Save(new Person());
            context.Save(new Subscription());
        }
    }

    public class DataContext<T, U, V> 
        where T : IPerson
        where U : Payment
        where V : Subscription 
    {
        public void Save(T entity){ }
        public void Save(U entity){ }
        public void Save(V entity){ }
    }

    public interface IPerson { }

    public class Person : IPerson{ }

    public class Payment{ }
 
    public class Subscription{ }
}
