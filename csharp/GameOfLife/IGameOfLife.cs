using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    interface IGameOfLife
    {
        // 4 Rules of Conway's Game of Life
        void Reproduction(object input);
        void UnderPopulation(object input);
        void OverPopulation(object input);
        void LiveOn(object input);
    }
}
