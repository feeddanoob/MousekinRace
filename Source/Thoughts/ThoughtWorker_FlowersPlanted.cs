﻿using RimWorld;
using Verse;

namespace MousekinRace
{
    public class ThoughtWorker_FlowersPlanted : ThoughtWorker_Precept
    {
        public override ThoughtState ShouldHaveThought(Pawn p)
        {
            return ThoughtState.ActiveAtStage(ThoughtStageIndex(p));
        }

        public int ThoughtStageIndex(Pawn p)
        {
            MapComponent_FlowerTracker flowerTracker = p.Map.GetComponent<MapComponent_FlowerTracker>();
            int flowersPlanted = flowerTracker.playerFlowersPlanted.Count;
            int varietyCount = flowerTracker.playerFlowerVarietiesPlanted;

            if (flowersPlanted == 0)
            {
                return 0;
            }
            if (flowersPlanted < flowerTracker.flowerThresholdLow)
            {
                return 1;
            }
            if (flowersPlanted >= flowerTracker.flowerThresholdMed)
            {
                if (varietyCount >= 2 && varietyCount < 3)
                {
                    return 3;
                }
                if (flowersPlanted >= flowerTracker.flowerThresholdHigh && varietyCount >= 3)
                {
                    return 4;
                }
            }
            return 2;
        }
    }
}
