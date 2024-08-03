using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class TruckFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }
}
