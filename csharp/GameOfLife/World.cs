using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class World : IGameOfLife
    {
        int[,] contents = new int[50,50]; // Where's my origin?
        // ^ 2-D array of zeros!! :D

        public World(int[,] live_cells)
        {
            for (int i = 0; i < (live_cells.Length)/2; i++)
            {
                // i represents a live cell (position)
                int live_cell_x_coord = live_cells[i, 0];
                int live_cell_y_coord = live_cells[i, 1];

                // It's alive!!!!!
                contents[live_cell_x_coord, live_cell_y_coord] = 1;
            }
        }

        public void LiveOn(object input)
        {
            throw new NotImplementedException();
        }

        public void OverPopulation(object input)
        {
            throw new NotImplementedException();
        }

        public void Reproduction(object input)
        {
            throw new NotImplementedException();
        }

        public void UnderPopulation(object input)
        {
            throw new NotImplementedException();
        }

        public int CountLiveNighbors(int x, int y)
        {
            int top, bottom, left, right, top_left, top_right;
            int bottom_left, bottom_right;

            top = contents[x, y + 1];
            bottom = contents[x, y - 1];
            left = contents[x-1, y];
            right = contents[x+1, y];
            bottom_left = contents[x-1, y - 1];
            top_left = contents[x-1, y + 1];
            bottom_right = contents[x+1, y - 1];
            top_right = contents[x+1,y+1];

            return top + bottom + bottom_left + bottom_right + left + top_left + top_right + right;
        }
    }
}
