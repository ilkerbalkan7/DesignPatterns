using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_DP
{
    class Program
    {

    }

    public abstract class CreateCustomer
    {
        public abstract void Create(string message);
    }

    public class CustomerIndividual : CreateCustomer
    {
        public override void Create(string message)
        {
            Console.WriteLine("Individual");
        }

    }

    public abstract class Caching
    {
        public abstract void Cache(string data);
    }

    public class MemoryCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cache MemoryCache");
        }
    }

    public abstract class CreateCustomerFactory
    {
        public abstract CreateCustomer CreateCustomer();

        public abstract Caching CreateCaching();
    }

    public class CreateCustomerIndivididual : CreateCustomerFactory
    {
        public override CreateCustomer CreateCustomer()
        {
            return new CustomerIndividual();
        }

        public override Caching CreateCaching()
        {
            return new MemoryCache();
        }
    }

    public class CustomerManager
    {
        private CreateCustomerFactory _createCustomerFactory;
        private CreateCustomer _createCustomer;
        private Caching _caching;

        public CustomerManager(CreateCustomerFactory createCustomerFactory)
        {
            _createCustomerFactory = createCustomerFactory;
            _createCustomer = createCustomerFactory.CreateCustomer();
            _caching = createCustomerFactory.CreateCaching();

        }

        public void Create()
        {
            _createCustomer.Create("Customer Created");
            _caching.Cache("Cahce");
        }
    }

}
