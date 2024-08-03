using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ConcreteHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void BuildWalls()
        {
            _house.Walls = "Concrete Walls";
        }

        public void BuildRoof()
        {
            _house.Roof = "Concrete Roof";
        }

        public void BuildDoors()
        {
            _house.Doors = "Wooden Doors";
        }

        public void BuildWindows()
        {
            _house.Windows = "Glass Windows";
        }

        public House GetHouse()
        {
            return _house;
        }
    }

}
