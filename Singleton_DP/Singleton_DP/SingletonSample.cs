using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_DP
{
    public static class SingletonSample
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Get_Instance;
            Singleton s2 = Singleton.Get_Instance;

            Console.WriteLine("Singleton Operation");
            Console.WriteLine(s1 == s2); // true 
            Console.ReadLine();

        }
    }
}
