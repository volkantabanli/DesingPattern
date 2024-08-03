using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Client
    {
        public void Main()
        {
            IVehicleFactory carFactory = new CarFactory();
            IVehicle car = carFactory.CreateVehicle();
            Console.WriteLine(car.Drive());

            IVehicleFactory truckFactory = new TruckFactory();
            IVehicle truck = truckFactory.CreateVehicle();
            Console.WriteLine(truck.Drive());
        }
    }
}
