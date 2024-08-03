using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class HouseDirector
    {
        private IHouseBuilder _houseBuilder;

        public HouseDirector(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void BuildHouse()
        {
            _houseBuilder.BuildWalls();
            _houseBuilder.BuildRoof();
            _houseBuilder.BuildDoors();
            _houseBuilder.BuildWindows();
        }

        public House GetHouse()
        {
            return _houseBuilder.GetHouse();
        }
    }

}
