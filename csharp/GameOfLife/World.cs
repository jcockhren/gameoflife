using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class World : IGameOfLife
    {
        Dictionary<string, LiveCell> contents;

        public World(LiveCell[] initial)
        {
            contents = new Dictionary<string, LiveCell>();

            foreach (LiveCell cell in initial)
            {
                contents.Add(cell.ToString(), cell);
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

        public int CountLiveNeighbors(int x, int y)
        {
            string top, top_left, top_right;
            string bottom, bottom_left, bottom_right;

            top = $"({x},{y+1})";
            top_left = $"({x-1},{y+1})";
            top_right = $"({x+1},{y+1})";
            bottom = $"({x},{y-1})";
            bottom_left = $"({x-1},{y-1})";
            bottom_right = $"({x+1},{y-1})";

            List<string> potential_neighbors = new List<string> { top, top_left, top_right, bottom, bottom_left, bottom_right };
            int neighbor_count = 0;
            foreach (var location in potential_neighbors)
            {
                if (contents.ContainsKey(location))
                {
                    neighbor_count++;
                }
            }
            return neighbor_count;
            
        }
    }
}
