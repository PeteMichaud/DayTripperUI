using Priority_Queue;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DayTripper
{
    /// <summary>
    /// Candidate tiles need to be stored in a priority queue as well as 
    /// a look up table for speed, so this encapsulates those details
    /// </summary>
    public class SearchCandidateCollection
    {
        private readonly FastPriorityQueue<SearchTile> _queue;
        private readonly SearchTile[,] _lookup;

        public int Count => _queue.Count;


        public SearchCandidateCollection(Size mapSize)
        {
            _queue = new FastPriorityQueue<SearchTile>(mapSize.Width * mapSize.Height);
            _lookup = new SearchTile[mapSize.Width, mapSize.Height];

        }

        public void Enqueue(SearchTile tile)
        {
            _queue.Enqueue(tile, tile.CostDistance);
            _lookup[tile.Location.X, tile.Location.Y] = tile;
        }

        public SearchTile Dequeue()
        {
            var tile = _queue.Dequeue();
            _lookup[tile.Location.X, tile.Location.Y] = null;
            return tile;
        }

        public void Remove(SearchTile tile)
        {
            _queue.Remove(tile);
        }

        public IEnumerator<SearchTile> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        public SearchTile this[int x, int y]
        {
            get
            {
                return _lookup[x, y];
            }
        }

        public SearchTile this[Point pt]
        {
            get
            {
                return _lookup[pt.X, pt.Y];
            }
        }

        public bool Any()
        {
            return _queue.Any();
        }
    }
}
