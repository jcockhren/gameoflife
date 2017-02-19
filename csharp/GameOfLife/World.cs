using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class World : IGameOfLife
    {
        public int[,] worldArr = new int[50,50];
        public List<string> about_to_die = new List<string>(); // List of cells marked to die
        public List<string> about_to_born = new List<string>(); // List of cells marked to born

        public World()
        {
        }

        public World(int[,] live_cells)
        {
            for (int i = 0; i < live_cells.Length/2; i++)
            {
                int live_cell_x_coord = live_cells[i, 0];
                int live_cell_y_coord = live_cells[i, 1];
                worldArr[live_cell_x_coord, live_cell_y_coord] = 1;
            }
        }

        public void Tick() // Passage of time
        {
            LiveOn(null);
            Reproduction(null);
            UnderPopulation(null);
            OverPopolation(null);

            KillCells();
            BirthCells();
        }

        private void BirthCells()
        {
            // look inside and set contents
            if (about_to_born.Any())
            {
                foreach (string cell in about_to_born)
                {
                    Match match = Regex.Match(cell, @"(\d+),(\d+)");
                    int x = int.Parse(match.Groups[1].Value);
                    int y = int.Parse(match.Groups[2].Value);
                    worldArr[x, y] = 1;
                }
            }
        }

        private void KillCells()
        {
            // look inside and set contents
            if (about_to_die.Any())
            {
                    foreach (string cell in about_to_die)
                {
                    Match match = Regex.Match(cell, @"(\d+),(\d+)");
                    int x =  int.Parse(match.Groups[1].Value);
                    int y = int.Parse(match.Groups[2].Value);
                    worldArr[x, y] = 0;
                }
            }
        }

        public void LiveOn(object input)
        {
            
        }

        public void OverPopolation(object input)
        {
            for (int y = 0; y < 50; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    if (worldArr[x, y] == 1)
                    {
                        int neighbors = CountLiveNeighbors(x, y);
                        if (neighbors > 3)
                        {
                            about_to_die.Add($"({x},{y})");
                        }
                    }
                }
            }
        }

        public void Reproduction(object input)
        {
            for (int y = 0; y < 50; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    if (worldArr[x, y] == 0)
                    {
                        int neighbors = CountLiveNeighbors(x, y);
                        if (neighbors == 3)
                        {
                            about_to_born.Add($"({x},{y})");
                        }
                    }
                }
            }
        }

        public void UnderPopulation(object input)
        {
            for (int y = 0; y < 50; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    if (worldArr[x, y] == 1)
                    {
                        int neighbors = CountLiveNeighbors(x, y);
                        if (neighbors < 2)
                        {
                            about_to_die.Add($"({x},{y})");
                        }
                    }
                }
            }
        }

        // needs to be a method to retrieve dead neighbors
        // now count the live neighbors relate to the dead neighbors positions

        public int CountLiveNeighbors(int x, int y)
        {
            if (x > 0 && y > 0 && x < 49 && y < 49)
            {
                int top, bottom, left, right, top_left, top_right, bottom_left, bottom_right;
                top = worldArr[x, y + 1];
                bottom = worldArr[x, y - 1];
                left = worldArr[x - 1, y];
                right = worldArr[x + 1, y];
                top_left = worldArr[x - 1, y + 1];
                top_right = worldArr[x + 1, y + 1];
                bottom_left = worldArr[x - 1, y - 1];
                bottom_right = worldArr[x + 1, y - 1];
                return top + bottom + left + right + top_left + top_right + bottom_left + bottom_right;
            }
            else
                return 0;

        }
    }
}
