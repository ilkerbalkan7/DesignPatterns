using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP
{
    class SampleFactory
    {
        static void Main(string[] args)
        {
            var Carfactory = new Gallery();

            Car carLamborghini = Carfactory.GetCar(CarType.Ferrari);
            carLamborghini.DisplayInfo();

            Car carFerrari = Carfactory.GetCar(CarType.Lamborghini);
            carFerrari.DisplayInfo();

            Console.ReadLine();


        }
    }
}
