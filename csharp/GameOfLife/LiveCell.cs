using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class LiveCell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public LiveCell()
        {
            X = 0;
            Y = 0;
        }

        public LiveCell(int x, int y)
        {
            X = x;
            Y = y;
        }
 
        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
