namespace DayTripper
{
    public class SearchSettings
    {
        public float CrowDistanceWeight = 3f;

        public float RoughTerrainStepCost = 4f;
        public float WaterStepCost = 1f;
        public float RoadStepCost = 0f;

        public float UphillPenalty = 10;
        public float DownhillPenalty = .5f;
        
        public float WaterEnterPenalty = 20f;
        public float WaterExitPenalty = 1f;

        public float RoadExitPenalty = 0f;

    }
}
