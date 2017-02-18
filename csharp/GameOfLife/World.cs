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

        List<string> about_to_die = new List<string>(); // List of cells marked to die
        List<string> about_to_live = new List<string>(); // List of cells marked to come alive

        public void Tick() // Passage of time
        {
            LiveOn(null);
            Reproduction(null);
            UnderPopulation(null);
            OverPopulation(null);

            KillCells();
            BirthCells();
        }

        private void BirthCells()
        {
            // look inside of about_to_live and set position to 1 them to the contents
            throw new NotImplementedException();
        }

        private void KillCells()
        {
            // look inside of about_to_die and set position to zero them from the contents
            throw new NotImplementedException();
        }

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
            // Iterate to find live cells and find THEIR dead neighbors.
            // GetDeadNeighbors
            // Iterate through all collected dead neighbors and call CountLiveNighbors on them
            // Stash the dead cells that have more than 3 live neighbors then add it to the 
            // about_to_live list
            throw new NotImplementedException();
        }

        public void UnderPopulation(object input)
        {
            for (int y = 0; y < 50; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    if(contents[y,x] == 1)
                    {
                        // Cell is alive
                        int neighbors = CountLiveNighbors(x, y);
                        if (neighbors < 2)
                        {
                            about_to_die.Add($"({x},{y})");
                        }
                    }
                }
            }
        }

        // 1. Needs to be a Method to retrieve dead neighbors
        // 2. Now count the live neighbors relative to the dead neightbors positions.

        public List<object> GetDeadNeighbors(int x, int y)
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
