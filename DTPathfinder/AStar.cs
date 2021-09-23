using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace DayTripper
{
    public static class AStar
    {

        public static List<SearchTile> FindPath(SearchableMap map, Point startPoint, Point targetPoint, 
            SearchSettings searchSettings, Action<int, int, int> progress, DebugSettings debugSettings)
        {

            if (debugSettings.DebugMode)
            {
                if (!Directory.Exists(debugSettings.DebugOutputDirectory))
                    Directory.CreateDirectory(debugSettings.DebugOutputDirectory);
            }

            SearchTile.SearchSettings = searchSettings;

            #region Local Methods

            SearchTile BuildSearchTile(Point location, SearchTile parent)
            {
                return new SearchTile(
                    location,
                    map[location].Elevation,
                    map[location].Water,
                    map[location].IsRoad,
                    HeuristicDistanceBetween(location, targetPoint),
                    parent
                );
            }

            List<SearchTile> GetWalkableFrom(SearchTile tile)
            {
                var possibleTiles = new List<SearchTile>(8);
                for (var x = -1; x < 2; x++)
                {
                    for (var y = -1; y < 2; y++)
                    {
                        if (x == 0 && y == 0) continue; // same tile
                        var newLocation = new Point(tile.Location.X + x, tile.Location.Y + y);
                        if (!map.InBounds(newLocation)) continue;
                        if (!map[newLocation].IsPassable) continue;

                        possibleTiles.Add(BuildSearchTile(newLocation, tile));
                    }
                }

                return possibleTiles;
            }

            #endregion

            var candidateTiles = new SearchCandidateCollection(map.Size);
            
            var closedLocations = new bool[map.Width, map.Height];
            var closedCount = 0;

            candidateTiles.Enqueue(BuildSearchTile(startPoint, null));

            while (candidateTiles.Any())
            {
                var currentTile = candidateTiles.Dequeue();

                if (currentTile.Location == targetPoint) //Found Goal
                {
                    return currentTile.PathBackToStart();
                }

                closedLocations[currentTile.Location.X, currentTile.Location.Y] = true;
                closedCount++;

                var walkableTiles = GetWalkableFrom(currentTile);

                foreach(var walkableTile in walkableTiles)
                {
                    if(closedLocations[walkableTile.Location.X, walkableTile.Location.Y]) continue;

                    var existingTile = candidateTiles[walkableTile.Location];

                    if (existingTile != null)
                    {
                        // if we have this tile on the list to look at already, 
                        //but the score is worse than this one, replace the worse score with this one
                        if(existingTile.CostDistance > walkableTile.CostDistance)
                        {
                            candidateTiles.Remove(existingTile);
                            candidateTiles.Enqueue(walkableTile);
                        }
                        //else we've seen this tile and the score is worse anyway, so do nothing
                    } 
                    else
                    {
                        //never seen this tile before, so add it to the list
                        candidateTiles.Enqueue(walkableTile);
                    }
                }

                if (closedCount % debugSettings.ProgressMessageInterval == 0)
                {
                    progress?.Invoke(currentTile.CrowDistance, candidateTiles.Count, closedCount);
                    if (debugSettings.DebugMode)
                    {
                        if (closedCount > debugSettings.DebugStart && closedCount % debugSettings.ImageOutputInterval == 0)
                        {
                            debugSettings.report?.Invoke(map, currentTile, candidateTiles, closedCount, targetPoint, debugSettings);
                        }
                    }
                }

            }

            return null; // No Path Exists
        }

        //The distance is essentially the estimated distance, ignoring walls to our target. 
        //So how many tiles left and right, up and down, ignoring walls, to get there. 
        static int HeuristicDistanceBetween(Point start, Point target) =>
            Math.Abs(target.X - start.X) + Math.Abs(target.Y - start.Y);
    }
}