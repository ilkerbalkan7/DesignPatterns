using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_DP
{
    public class Car: ICloneable
    {
    public string CarName { get; set; }

    public double Accelaration { get; set; }

    public double TopSpeed { get; set; }

    public double Handling { get; set; }

    public double Nitro { get; set; }


    public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
    public class RacerCars: List<Car>
    {
        public void Race()
        {
            foreach (var item in this)
            {
                Console.WriteLine("Name of the car:{0}, Top Speed:{1}, Handling:{2}, Nitro:{3}, ", item.CarName, item.Accelaration, item.TopSpeed,
                    item.Handling, item.Nitro);
            }
        }
    }
}
