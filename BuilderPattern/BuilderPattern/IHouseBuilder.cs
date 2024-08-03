using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IHouseBuilder
    {
        void BuildWalls();
        void BuildRoof();
        void BuildDoors();
        void BuildWindows();
        House GetHouse();
    }
}
