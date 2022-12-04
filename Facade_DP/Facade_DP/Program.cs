using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Facade_DP;


public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}

public class ProductInCart
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }

}

public class ShippingCompany
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Contact { get; set; }

}

public class OrderProcessing
{
    public int AddOrder(DateTime datetime, Customer customer, ShippingCompany shippingcomnpany)
    {
        Console.WriteLine("At the time {0}, person {1} added an order. Selected shipping company is {2}.",
            datetime.ToString(), customer.Name, shippingcomnpany.Name);
        return 1;
    }
}

public class OrderDetail
{
    public void AddOrderDetail(int OrderID, List<ProductInCart> products)
    {
        Console.WriteLine(" He bought products on the order number {0}: ", OrderID);
        Console.WriteLine("..............................");
        products.ForEach(u => Console.WriteLine(" product of {0} is sold with the count {1}. Subtotal:{2}", u.ProductName, u.Count, u.Count * u.Price));
        Console.WriteLine("..............................");
        var sum = products.Sum(x => x.Price * x.Count);
        Console.WriteLine("Sum:{0}", sum);
    }
}

public class ProductProcess

{
    public void StockUpdate(int productID, int count)
    {
        Console.WriteLine("The item in the stock of the ID {0} is decreased {1}.", productID, count);
    }
}

public class OrderFacade
{
    private Customer customer;
    private ShippingCompany shippingcompany;
    private ProductProcess productprocess = new ProductProcess();
    private OrderProcessing orderprocessing = new OrderProcessing();
    private OrderDetail orderdetail = new OrderDetail();



    public void Order(string customerName, string selectedShippingCompany, List<ProductInCart> products)
    {
        customer = new Customer { Name = customerName };
        shippingcompany = new ShippingCompany { Name = selectedShippingCompany };
        int orderID = orderprocessing.AddOrder(DateTime.Now, customer, shippingcompany);
        orderdetail.AddOrderDetail(orderID, products);
        products.ForEach(u => productprocess.StockUpdate(u.Id, u.Count));
        Console.WriteLine();
        Console.WriteLine("The process is done.");


    }
}

class Program
{
    static void Main(string[] args)
    {
        OrderFacade orderFacade = new OrderFacade();
        List<ProductInCart> products = new List<ProductInCart>
        {
            new ProductInCart { Id=1, ProductName="X", Price= 5,  Count= 2 },
            new ProductInCart { Id=2, ProductName="Y", Price= 8,  Count= 3 },
            new ProductInCart { Id=1, ProductName="Z", Price= 10, Count= 1 },
            new ProductInCart { Id=1, ProductName="Q", Price= 20, Count= 1 },
        };
orderFacade.Order("İlker Balkan", "Yurtici Kargo", products);
Console.ReadLine();
    }

}



