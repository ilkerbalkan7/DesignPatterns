using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Pool_DP
{
    class Sample_ObjectPool
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Havuzun boyutu {0}", ClientPool.Instance.Size);

            Console.WriteLine("Client sınıfı ediniyoruz.");
            var client1 = ClientPool.Instance.AcquireObject();

            client1.Connect();

            Console.WriteLine("Client'ı geri bırakıyoruz");
            if (client1 != null)
                ClientPool.Instance.ReleaseObject(client1);

            var clients = new List<Client>();
            for (int i = 0; i < ClientPool.Instance.Size; i++)
            {
                clients.Add(ClientPool.Instance.AcquireObject());
            }

            Console.WriteLine("Uygun olan tüm Client nesneleri listeye eklendi.");

            var nullClient = ClientPool.Instance.AcquireObject();

            if (nullClient == null)
                Console.WriteLine("Daha fazla Client sınıfı bulunmamaktadır.");

            Console.WriteLine("Havuzun boyutunu arttırıyoruz");
            ClientPool.Instance.IncreaseSize();

            Console.WriteLine("Yeni bir Client sınıfı ediniyoruz.");
            var newClient = ClientPool.Instance.AcquireObject();

            newClient.Connect();

            Console.WriteLine("Edindiğimiz sınıfı geri veriyoruz.");
            if (newClient != null)
                ClientPool.Instance.ReleaseObject(newClient);

            Console.WriteLine("Listedeki tüm Client sınıflarını geri bırakıyoruz.");

            foreach (var item in clients)
                ClientPool.Instance.ReleaseObject(item);
        }

    }

}

    