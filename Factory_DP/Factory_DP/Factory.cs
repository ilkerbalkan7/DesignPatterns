using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP
{
    class Factory
    {
        
    }

    public interface Car
    {
        void DisplayInfo();
    }
    public class Lamborghini : Car
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Lamborghini Aventador");
        }
    }

    public class Ferrari : Car
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Ferrari F40");
        }
    }

    public enum CarType
    {
        Lamborghini = 5,
        Ferrari = 7

    }
    
    public interface CarDesign
    {
        Car GetCar(CarType type);
    }

    public class Gallery: CarDesign
    {
        public Car GetCar(CarType type)
        {
            Car car = null;
            switch (type)
            {
                case CarType.Lamborghini:
                    car = new Lamborghini();
                    break;
                case CarType.Ferrari:
                    car = new Ferrari();
                    break;

            }
            return car;
                
        }
    }
}
