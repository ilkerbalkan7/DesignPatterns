using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_DP
{
    class Sample_Factory_Abstract
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new CreateCustomerIndivididual());
            customerManager.Create();
            Console.ReadLine();
        }
    }
}

