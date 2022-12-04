using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_DP;

public interface IProductService
{
    List<string> GetProductName();
}

public class ProductService : IProductService
{
    public List<string> GetProductName()
    {
        //veritabannına bağlanarak ilgili ürünleri aldığımızı ve bu sonucu döndürdüğümüzü varsayın.
        return new List<string>() { "Saat", "Gömlek", "Tirbuşon" };
    }
}

public class ProductServiceProxy : IProductService
{
    //Dikkat: İşi yapacak olan gerçek nesne, bir "alan" olarak tanımlandı:
    private ProductService productService = null;
    public List<string> GetProductName()
    {
        //proxy nesnemizin bu metodu, gerçek nesnenin aynı metodunu çağıracak:
        productService = new ProductService();
        return productService.GetProductName();
    }
}

internal class Proxy
{
    // Burası client
    static void Main(string[] args)
    {
        ProductServiceProxy productServiceProxy = new ProductServiceProxy();
        productServiceProxy.GetProductName();
        Console.ReadLine();

    }
}

