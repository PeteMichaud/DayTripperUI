using System;
using System.Collections.Generic;
using System.Drawing;
using Priority_Queue;

namespace DayTripper
{
    public class SearchTile : FastPriorityQueueNode
    {
        public static SearchSettings SearchSettings;

        public readonly Point Location;
        public readonly ushort Elevation;
        public readonly ushort Water;
        public readonly bool IsRoad;
        public readonly float Cost;
        public readonly int CrowDistance;
        public float CostDistance => Cost + CrowDistance * SearchSettings.CrowDistanceWeight;
        public bool IsWater => Water > SearchableMap.BoolReadingThreshold;
        public readonly SearchTile Parent;

        public SearchTile(Point location, ushort elevation, ushort water, bool road, int crowDistance, SearchTile parent)
        {
            Location = location;
            Elevation = elevation;
            Water = water;
            IsRoad = road;
            Parent = parent;
            CrowDistance = crowDistance;
            Cost = CalculateCost();
        }
        
        public SearchTile(Point location, ushort elevation, ushort water, bool road, int crowDistance)
            : this(location, elevation, water, road, crowDistance, null)
        { }

        public override int GetHashCode()
        {
            return Location.GetHashCode();
        }

        public List<SearchTile> PathBackToStart()
        {
            if (Parent == null) return new List<SearchTile>() { this };

            var parentList = Parent.PathBackToStart();
            parentList.Add(this);
            return parentList;
        }

        private float CalculateCost()
        {
            if (Parent == null) return 0;

            var diagonal = !(Parent.Location.X - Location.X == 0 || Parent.Location.Y - Location.Y == 0);

            float intrinsicStepCost = diagonal ? 1.4f : 1; //intrinsic cost of taking another step
            float terrainTypeStepCost = 0;
            float stepPenalty = 0; 

            if (IsRoad)
            {
                //roads ignore elevation and water
                terrainTypeStepCost = intrinsicStepCost * SearchSettings.RoadStepCost;
                return intrinsicStepCost + terrainTypeStepCost + Parent.Cost;
            }
            else
            {
                var isExitingRoad = Parent.IsRoad;
                stepPenalty += isExitingRoad ? SearchSettings.RoadExitPenalty : 0;
            }

            { //Elevation Cost
                var elevationDifference = (float)(Elevation - Parent.Elevation);

                stepPenalty += intrinsicStepCost * Math.Abs(elevationDifference) * (elevationDifference > 0
                    ? SearchSettings.UphillPenalty
                    : SearchSettings.DownhillPenalty);
            }

            { //Water Cost

                if (!this.IsWater)
                {
                    terrainTypeStepCost = intrinsicStepCost * SearchSettings.RoughTerrainStepCost;

                    var isExitingWater = Parent.IsWater;
                    stepPenalty += isExitingWater ? SearchSettings.WaterExitPenalty : 0;
                }
                else //this tile is water
                {
                    terrainTypeStepCost = intrinsicStepCost * SearchSettings.WaterStepCost;

                    var isEnteringWater = !Parent.IsWater;
                    stepPenalty += isEnteringWater ? SearchSettings.WaterEnterPenalty : 0;
                }
            }

            return intrinsicStepCost + terrainTypeStepCost + stepPenalty + Parent.Cost;
        }

    }
}
