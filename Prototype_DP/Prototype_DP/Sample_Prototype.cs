using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_DP
{
    class Sample_Prototype
    {
        private static RacerCars racers;

        public static RacerCars RacerCars { get; private set; }

        static void Main(string[] args)
        {
            Car prototype = new Car();
            prototype.CarName = "Alfa Romeo Mito GTA";
            prototype.Accelaration = 6.50;
            prototype.TopSpeed = 240.1;
            prototype.Handling = 1.300;
            prototype.Nitro = 10;

            Car copy1 = (Car)prototype.Clone();
            copy1.CarName = "Mini Cooper S Roadster";
            prototype.Accelaration = 7.00;
            prototype.TopSpeed = 227.2;
            prototype.Handling = 1.250;
            prototype.Nitro = 10;

            Car copy2 = (Car)prototype.Clone();
            copy2.CarName = "Scion FR-S";
            prototype.Accelaration = 6.20;
            prototype.TopSpeed = 224.2;
            prototype.Handling = 1.270;
            prototype.Nitro = 22.9;

            Car copy3 = (Car)prototype.Clone();
            copy3.CarName = "Cadillac XTS";
            prototype.Accelaration = 7.00;
            prototype.TopSpeed = 218.6;
            prototype.Handling = 1.180;
            prototype.Nitro = 10;

            Car copy4 = (Car)prototype.Clone();
            copy4.CarName = "Bugatti Veyron Grand Sport";
            prototype.Accelaration = 7.00;
            prototype.TopSpeed = 227.2;
            prototype.Handling = 1.250;
            prototype.Nitro = 10;

            Car copy5 = (Car)prototype.Clone();
            copy5.CarName = "Lamborghini Aventador";
            prototype.Accelaration = 2.60;
            prototype.TopSpeed = 409.4;
            prototype.Handling = 1.180;
            prototype.Nitro = 20.3;

            RacerCars = racers = new RacerCars
            {
                copy1,
                copy2,
                copy3,
                copy4,
                copy5
            };

            racers.Race();
        }
    }

}

