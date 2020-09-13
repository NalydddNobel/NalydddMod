using nalydmod.Npcs.Enemies.Bosses.LunarPillar;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
namespace nalydmod
{
    public class MyWorld : ModWorld
    {

        //Lunar pillar stuff

        public const int maxLunarPillarPeonsKilled = 150;
        public static int LunarPillarPeonsKilled;
        public static bool pillarAequusInvasion;

        //Boss downs

        public static bool DownedMage1;
        public static bool DownedLunarPillar;
        public static bool DownedEoC2;
        public static bool DownedGeodeWorm;

        //Treasure bags opened

        public static bool openedKingSlimeBag;
        public static bool openedBoss1Bag;
        public static bool openedBoss2CorruptionBag;
        public static bool openedBoss2CrimsonBag;
        public static bool openedQueenBeeBag;
        public static bool openedBoss3Bag;
        public static bool openedGeodeWormBag;
        public static bool openedMage1Bag;
        public static bool openedLunarPillarBag;
        public static bool openedEoC2Bag;

        //Player events

        public static bool extraBuffedMode;
        public static bool SuperHardMode;

        //Biomes

        public static int ZoneLunar;
        public static int BiomeLunar;

        //??

        public static int wofWeakness;
        bool spawn;
        public static bool firstNight;
        public override void Initialize()
        {
            LunarPillarPeonsKilled = 0;
            pillarAequusInvasion = false;
            DownedMage1 = false;
            DownedGeodeWorm = false;
            DownedLunarPillar = false;
            DownedEoC2 = false;
            extraBuffedMode = false;
            SuperHardMode = false;
            firstNight = false;
            openedKingSlimeBag = false;
            openedBoss1Bag = false;
            openedBoss2CorruptionBag = false;
            openedBoss2CrimsonBag = false;
            openedQueenBeeBag = false;
            openedBoss3Bag = false;
        }
        public override void Load(TagCompound tag)
        {

            //Lunar pillar

            LunarPillarPeonsKilled = tag.GetInt("LunarPillarPeonsKilled");
            pillarAequusInvasion = tag.GetBool("pillarAequusInvasion");

            //Boss downs

            DownedMage1 = tag.GetBool("DownedMage1");
            DownedEoC2 = tag.GetBool("EoC2");
            DownedGeodeWorm = tag.GetBool("DownedGeodeWorm");

            //Opened boss bags

            openedKingSlimeBag = tag.GetBool("openedKingSlimeBag");
            openedBoss1Bag = tag.GetBool("openedBoss1Bag");
            openedBoss2CorruptionBag = tag.GetBool("openedBoss2CorruptionBag");
            openedBoss2CrimsonBag = tag.GetBool("openedBoss2CrimsonBag");
            openedQueenBeeBag = tag.GetBool("openedQueenBeeBag");
            openedBoss3Bag = tag.GetBool("openedBoss3Bag");

            //Player events

            SuperHardMode = tag.GetBool("SuperHardMode");
            extraBuffedMode = tag.GetBool("extraBuffedMode");

            //??

            firstNight = tag.GetBool("firstNight");

        }
        public override TagCompound Save()
        {
            return new TagCompound
            {

                //Lunar pillar 

                {"LunarPillarPeonsKilled", LunarPillarPeonsKilled},
                {"pillarAequusInvasion", pillarAequusInvasion},

                //Boss downs

                {"DownedMage1", DownedMage1},
                {"DownedLunarPillar", DownedLunarPillar},
                {"EoC2", DownedEoC2},
                {"DownedGeodeWorm", DownedGeodeWorm},

                //Treasure bags opened

                {"openedKingSlimeBag", openedKingSlimeBag},
                {"openedBoss1Bag", openedBoss1Bag},
                {"openedBoss2CorruptionBag", openedBoss2CorruptionBag},
                {"openedBoss2CrimsonBag", openedBoss2CrimsonBag},
                {"openedBoss3Bag", openedBoss3Bag},
                {"openedQueenBeeBag", openedQueenBeeBag},

                //Player events
                
                {"SuperHardMode", SuperHardMode},
                {"extraBuffedMode", extraBuffedMode},

                //??

                {"firstNight", firstNight},

            };
        }
        public override void PreUpdate()
        {
            if (!firstNight)
            {
                if (Main.dayTime && Main.time == 0)
                {
                    if (extraBuffedMode)
                    {
                        Main.NewText("The first night has passed... are you even ready for whats next?", 200, 200, 200);
                    }
                    else if (Main.expertMode)
                    {
                        Main.NewText("The first night has passed... good luck surviving", 200, 200, 200);
                    }
                    else
                    {
                        Main.NewText("The first night has passed... the world shall bend to your will", 200, 200, 200);
                    }
                    firstNight = true;
                }
            }
            if (LunarPillarPeonsKilled > maxLunarPillarPeonsKilled)
            {
                LunarPillarPeonsKilled = maxLunarPillarPeonsKilled;
            }
            if (pillarAequusInvasion && !spawn)
            {
                NPC.NewNPC((Main.spawnTileX + 5) * 16, Main.spawnTileY * 11, ModContent.NPCType<LunarPillar>(), 0, 0f, 0f, 0f, 0f, 255);
                spawn = true;
            }
            if (!NPC.AnyNPCs(ModContent.NPCType<LunarPillar>()) && pillarAequusInvasion)
            {
                LunarPillarPeonsKilled = 0;
                pillarAequusInvasion = false;
                SuperHardMode = true;
                spawn = false;
            }
            if (pillarAequusInvasion && Main.LocalPlayer.position.X > 100 && Main.LocalPlayer.position.X < -100 && Main.LocalPlayer.position.Y > 100 && Main.LocalPlayer.position.Y < -100)
            {
                MyPlayer.LunarZone = true;
            }
        }
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new Terraria.GameContent.Generation.PassLegacy("Fractalite", NewModOres));
            }
        }
        private void NewModOres(GenerationProgress progress)
        {
            progress.Message = "Adding New Mod Ores";
            for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-06); k++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.rockLayerLow, Main.maxTilesY);
                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(12, 16), WorldGen.genRand.Next(4, 8), mod.TileType("FractaliteTile"));
            }
            //int count = 0;
            //while (count < 1)
            //{
            //    for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-04); k++)
            //    {
            //        int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            //        int y = WorldGen.genRand.Next((int)WorldGen.worldSurface, Main.maxTilesY);
            //        Tile tile = Framing.GetTileSafely(x, y);
            //        if (tile.active() && tile.type == TileID.Mud || tile.type == TileID.JungleGrass)
            //        {
            //            WorldGen.TileRunner(x, y, WorldGen.genRand.Next(4, 6), WorldGen.genRand.Next(3, 6), mod.TileType("LunarWoodTile"));
            //        }
            //    }
            //    count++;
            //}
        }
        public override void PostWorldGen()
        {
            int[] GoldChestLoot = { mod.ItemType("LifeBand"), mod.ItemType("AAGeodeWorm") };
            int GoldChestsChoice = 0;
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 1 * 36)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                        {
                            if (chest.item[inventoryIndex].type == ItemID.None)
                            {
                                chest.item[inventoryIndex].SetDefaults(Main.rand.Next(GoldChestLoot));
                                GoldChestsChoice = (GoldChestsChoice + 1) % GoldChestLoot.Length;
                                break;
                            }
                        }
                    }
                }
            }
            int[] HellChestsLoot = { mod.ItemType("LavaRing") };
            int HellChestsChoice = 0;
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 4 * 36)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                        {
                            if (chest.item[inventoryIndex].type == ItemID.None)
                            {
                                chest.item[inventoryIndex].SetDefaults(Main.rand.Next(HellChestsLoot));
                                HellChestsChoice = (HellChestsChoice + 1) % HellChestsLoot.Length;
                                break;
                            }
                        }
                    }
                }
            }
            int[] DungeonLoot = { mod.ItemType("DungeonBoomerang") };
            int DungeonLootChoice = 0;
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 2 * 36)
                {
                    if (Main.rand.Next(3) == 0)
                    {
                        for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                        {
                            if (chest.item[inventoryIndex].type == ItemID.None)
                            {
                                chest.item[inventoryIndex].SetDefaults(Main.rand.Next(DungeonLoot));
                                DungeonLootChoice = (DungeonLootChoice + 1) % DungeonLoot.Length;
                                break;
                            }
                        }
                    }
                }
            }
        }
        public override void TileCountsAvailable(int[] tileCounts)
        {
            BiomeLunar = tileCounts[mod.TileType("LunarGrassTile")];
        }
    }
}