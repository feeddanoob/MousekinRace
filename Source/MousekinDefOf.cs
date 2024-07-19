﻿using RimWorld;
using System.Collections.Generic;
using Verse;

namespace MousekinRace
{
    [DefOf]
    public static class MousekinDefOf
    {
        public static ThingDef Mousekin;

        public static ThingDef Mousekin_AnimalGiantCavy;
        public static ThingDef Mousekin_AnimalPudgemouse;

        public static ThingDef Meat_Chicken;
        public static ThingDef Meat_Cow;
        public static ThingDef Meat_Deer;
        public static ThingDef Meat_Duck;
        public static ThingDef Meat_Goat;
        public static ThingDef Meat_Pig;
        public static ThingDef Meat_Sheep;

        public static ThingDef Mousekin_Beehive;
        public static ThingDef Mousekin_Windmill;
        public static ThingDef Mousekin_TownSquare;

        public static ThingDef Blueprint_Mousekin_Windmill;

        public static ThingDef Mousekin_Beeswax;
        public static ThingDef Mousekin_RawHoney;

        public static List<ThingDef> FactionRestrictedThingDefs
        {
            get 
            {
                List<ThingDef> thingDefs = new();
                foreach (Faction faction in GameComponent_Allegiance.Instance.alliableFactions)
                {
                    thingDefs.AddRange(faction.def.GetModExtension<AlliableFactionExtension>().factionRestrictedCraftableThingDefs);
                }
                return thingDefs;
            }
        }

        public static ThoughtDef Mousekin_Thought_AteCheese;

        public static TraitDef Mousekin_TraitSpectrum_Faith;

        public static BodyPartDef Mousekin_Ear;

        public static HediffDef Mousekin_ProstheticClothEar;
        public static HediffDef Mousekin_HemlockPoisoning;

        public static MentalBreakDef Mousekin_MentalBreak_ExitAfterAllegianceChange;

        public static MentalStateDef Mousekin_MentalState_EarlessSuicide;
        public static MentalStateDef Mousekin_MentalState_ExitAfterAllegianceChange;

        public static DamageDef Mousekin_GunpowderExplosion;
        public static DamageDef Mousekin_SuicideKnife;
        public static DamageDef Mousekin_SuicidePoison;

        public static JobDef Mousekin_Job_CommitSuicideWithKnife;
        public static JobDef Mousekin_Job_CommitSuicideWithPoison;
        public static JobDef Mousekin_Job_HarvestFromBeehive;

        public static PawnKindDef MousekinColonist;

        public static FactionDef Mousekin_PlayerFaction_Settlers;
        public static FactionDef Mousekin_FactionKingdom;
        public static FactionDef Mousekin_FactionIndyTown;

        [MayRequireRoyalty]
        public static QuestScriptDef EndGame_RoyalAscent;

        [MayRequireIdeology]
        public static MemeDef AnimalPersonhood;

        [MayRequireIdeology]
        public static MemeDef Mousekin_IdeoMeme_AncestorWorship;

        [MayRequireIdeology]
        public static MemeDef Mousekin_IdeoMeme_RodentPurity;

        [MayRequireIdeology]
        public static PreceptDef HAR_AlienRaces_Standard;

        [MayRequireIdeology]
        public static PreceptDef HAR_AlienRaces_Respected;

        [MayRequireIdeology]
        public static PreceptDef HAR_AlienRaces_Exalted;

        [MayRequireBiotech]
        public static PawnKindDef MousekinChild;

        [MayRequireBiotech]
        public static XenotypeDef Mousekin_XenotypeMousekin;
    }
}
