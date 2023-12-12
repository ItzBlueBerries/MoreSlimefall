﻿using Il2CppMonomiPark.SlimeRancher.Weather.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreSlimefall.Assist
{
    public static class LocalSpawnActivities
    {
        // HASHSETS
        public static readonly List<SpawnActorActivity> _globalSpawnActivities = new List<SpawnActorActivity>();
        public static readonly List<SpawnActorActivity> _nighttimeSpawnActivities = new List<SpawnActorActivity>();

        // RANGES
        public static readonly Il2Cpp.Range ZERO = new Il2Cpp.Range() { Min = 0, Max = 0 };
        public static readonly Il2Cpp.Range ONE_TO_TWO = new Il2Cpp.Range() { Min = 1, Max = 2 };
        public static readonly Il2Cpp.Range TWO_TO_THREE = new Il2Cpp.Range() { Min = 2, Max = 3 };
        public static readonly Il2Cpp.Range THREE_TO_FIVE = new Il2Cpp.Range() { Min = 3, Max = 5 };
        public static readonly Il2Cpp.Range NINTY_TO_ONE_TWENTY = new Il2Cpp.Range() { Min = 90, Max = 120 };

        public static readonly Il2Cpp.Range EVERY_FIVE = new Il2Cpp.Range() { Min = 5, Max = 5 };
        public static readonly Il2Cpp.Range EVERY_TEN = new Il2Cpp.Range() { Min = 10, Max = 10 };
        public static readonly Il2Cpp.Range EVERY_TWENTY = new Il2Cpp.Range() { Min = 20, Max = 20 };
        public static readonly Il2Cpp.Range EVERY_THIRTY = new Il2Cpp.Range() { Min = 30, Max = 30 };
        public static readonly Il2Cpp.Range EVERY_SIXTY = new Il2Cpp.Range() { Min = 60, Max = 60 };

        // OUTBREAK
        public static SpawnActorActivity outbreakRainTarrSlimes;

        // GLOBAL
        public static SpawnActorActivity globalRainPinkSlimes;

        public static SpawnActorActivity globalRainPuddleSlimes;
        public static SpawnActorActivity globalRainTangleSlimes;
        public static SpawnActorActivity globalRainDervishSlimes;

        public static SpawnActorActivity globalRainRareSlimes;

        /*internal static SpawnActorActivity globalRainYolkySlimes;
        internal static SpawnActorActivity globalRainLuckySlimes;
        internal static SpawnActorActivity globalRainGoldSlimes;*/

        // ZONED
        // -- FIELDS
        public static SpawnActorActivity fieldsRainCottonSlimes;
        public static SpawnActorActivity fieldsRainTabbySlimes;
        public static SpawnActorActivity fieldsRainPhosphorSlimes;

        // -- STRAND
        public static SpawnActorActivity strandRainRockSlimes;

        public static SpawnActorActivity strandRainCottonSlimes;
        public static SpawnActorActivity strandRainAnglerSlimes;
        public static SpawnActorActivity strandRainPhosphorSlimes;

        public static SpawnActorActivity strandRainHoneySlimes;
        public static SpawnActorActivity strandRainFlutterSlimes;
        public static SpawnActorActivity strandRainRingtailSlimes;
        public static SpawnActorActivity strandRainHunterSlimes;

        public static void Load(string sceneName)
        {
            switch (sceneName)
            {
                case "GameCore":
                    {
                        #region OUTBREAK
                        // TARR
                        outbreakRainTarrSlimes = CreateActivity(Get<SlimeDefinition>("Tarr"), "Outbreak Rain Tarr Slimes");
                        outbreakRainTarrSlimes.SecondsBetweenSpawns = ONE_TO_TWO;
                        #endregion

                        #region GLOBAL
                        // PINK
                        globalRainPinkSlimes = CreateActivity(Get<SlimeDefinition>("Pink"), "Global Rain Pink Slimes");

                        // TANGLE
                        globalRainPuddleSlimes = CreateActivity(Get<SlimeDefinition>("Puddle"), "Global Rain Puddle Slimes");
                        globalRainPuddleSlimes.SecondsBetweenSpawns = EVERY_THIRTY;

                        // TANGLE
                        globalRainTangleSlimes = CreateActivity(Get<SlimeDefinition>("Tangle"), "Global Rain Tangle Slimes");
                        globalRainTangleSlimes.SecondsBetweenSpawns = EVERY_THIRTY;

                        // DERVISH
                        globalRainDervishSlimes = CreateActivity(Get<SlimeDefinition>("Dervish"), "Global Rain Dervish Slimes");
                        globalRainDervishSlimes.SecondsBetweenSpawns = EVERY_THIRTY;

                        // RARE
                        globalRainRareSlimes = CreateActivity(null, "Global Rain Rare Slimes");
                        globalRainRareSlimes.SecondsBetweenSpawns = NINTY_TO_ONE_TWENTY;

                        /* YOLKY
                        globalRainYolkySlimes = CreateActivity(Get<SlimeDefinition>("Yolky"), "Global Rain Yolky Slimes");
                        globalRainYolkySlimes.SecondsBetweenSpawns = EVERY_THIRTY;

                        // LUCKY
                        globalRainLuckySlimes = CreateActivity(Get<SlimeDefinition>("Lucky"), "Global Rain Lucky Slimes");
                        globalRainLuckySlimes.SecondsBetweenSpawns = EVERY_SIXTY;

                        // GOLD
                        globalRainGoldSlimes = CreateActivity(Get<SlimeDefinition>("Gold"), "Global Rain Gold Slimes");
                        globalRainGoldSlimes.SecondsBetweenSpawns = EVERY_SIXTY;*/

                        // LIST OF GLOBAL ACTIVITIES
                        _globalSpawnActivities.AddRange(new List<SpawnActorActivity>()
                        {
                            globalRainPinkSlimes,
                            globalRainPuddleSlimes,
                            globalRainTangleSlimes,
                            globalRainDervishSlimes,
                            globalRainRareSlimes
                            /*globalRainYolkySlimes,
                            globalRainLuckySlimes,
                            globalRainGoldSlimes*/
                        });
                        #endregion

                        #region ZONED

                        #region RAINBOW_FIELDS
                        // #NORMAL
                        // COTTON
                        fieldsRainCottonSlimes = CreateActivity(Get<SlimeDefinition>("Cotton"), "Fields Rain Cotton Slimes");

                        // #MODERATE
                        // TABBY
                        fieldsRainTabbySlimes = CreateActivity(Get<SlimeDefinition>("Tabby"), "Fields Rain Tabby Slimes");
                        fieldsRainTabbySlimes.SecondsBetweenSpawns = EVERY_FIVE;

                        // PHOSPHOR
                        fieldsRainPhosphorSlimes = CreateActivity(Get<SlimeDefinition>("Phosphor"), "Fields Rain Phosphor Slimes");
                        fieldsRainPhosphorSlimes.SecondsBetweenSpawns = EVERY_FIVE;
                        #endregion

                        #region STARLIGHT_STRAND
                        // #NORMAL
                        // ROCK
                        strandRainRockSlimes = CreateActivity(Get<SlimeDefinition>("Rock"), "Strand Rain Rock Slimes");

                        // #MODERATE
                        // COTTON
                        strandRainCottonSlimes = CreateActivity(Get<SlimeDefinition>("Cotton"), "Strand Rain Cotton Slimes");
                        strandRainCottonSlimes.SecondsBetweenSpawns = THREE_TO_FIVE;

                        // ANGLER
                        strandRainAnglerSlimes = CreateActivity(Get<SlimeDefinition>("Angler"), "Strand Rain Angler Slimes");
                        strandRainAnglerSlimes.SecondsBetweenSpawns = EVERY_FIVE;

                        // PHOSPHOR
                        strandRainPhosphorSlimes = CreateActivity(Get<SlimeDefinition>("Phosphor"), "Strand Rain Phosphor Slimes");
                        strandRainPhosphorSlimes.SecondsBetweenSpawns = EVERY_FIVE;

                        // #SEVERE
                        // HONEY
                        strandRainHoneySlimes = CreateActivity(Get<SlimeDefinition>("Honey"), "Strand Rain Honey Slimes");
                        strandRainHoneySlimes.SecondsBetweenSpawns = EVERY_TEN;

                        // FLUTTER
                        strandRainFlutterSlimes = CreateActivity(Get<SlimeDefinition>("Flutter"), "Strand Rain Flutter Slimes");
                        strandRainFlutterSlimes.SecondsBetweenSpawns = EVERY_TEN;

                        // RINGTAIL
                        strandRainRingtailSlimes = CreateActivity(Get<SlimeDefinition>("Ringtail"), "Strand Rain Ringtail Slimes");
                        strandRainRingtailSlimes.SecondsBetweenSpawns = EVERY_TWENTY;

                        // HUNTER
                        strandRainHunterSlimes = CreateActivity(Get<SlimeDefinition>("Hunter"), "Strand Rain Hunter Slimes");
                        strandRainHunterSlimes.SecondsBetweenSpawns = EVERY_TWENTY;
                        #endregion

                        #endregion

                        _nighttimeSpawnActivities.AddRange(new List<SpawnActorActivity>()
                        {
                            fieldsRainPhosphorSlimes,
                            strandRainPhosphorSlimes,
                            strandRainRingtailSlimes
                        });
                        break;
                    }
            }
        }

        public static SpawnActorActivity CreateActivity(IdentifiableType identifiable, string name)
        {
            SpawnActorActivity baseSpawnActivity = Get<SpawnActorActivity>("Rain Pink Slimes");
            SpawnActorActivity spawnActivity = ScriptableObject.CreateInstance<SpawnActorActivity>();
            spawnActivity.hideFlags |= HideFlags.HideAndDontSave;
            spawnActivity.name = name;
            spawnActivity.ActorType = identifiable;

            spawnActivity.ConnectedFX = baseSpawnActivity.ConnectedFX;
            spawnActivity.SpawnStrategy = baseSpawnActivity.SpawnStrategy;
            spawnActivity.ShouldConnectedFX = true;
            spawnActivity.SecondsBetweenSpawns = TWO_TO_THREE;
            return spawnActivity;
        }
    }
}
