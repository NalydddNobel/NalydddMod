using nalydmod.Items.Materials.GemFragments;
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
        public const int maxLunarPillarPeonsKilled = 150;
        public static int LunarPillarPeonsKilled;
        public static bool pillarAequusInvasion;
        public static bool SuperHardMode;
        public static bool DownedMage1; 
        public static bool DownedEoC2;
        public static bool DownedGeodeWorm;
        public static bool ModExpertMode;
        public static int ZoneLunar;
        public static int BiomeLunar;
        public static int wofWeakness;
        bool spawn;
        public override TagCompound Save()
        {
            return new TagCompound
            {
                {"LunarPillarPeonsKilled", LunarPillarPeonsKilled},
                {"pillarAequusInvasion", pillarAequusInvasion},
                {"SuperHardMode", SuperHardMode},
                {"DownedMage1", DownedMage1},
                {"EoC2", DownedEoC2},
                {"DownedGeodeWorm", DownedGeodeWorm},
            };
        }
        public override void Load(TagCompound tag)
        {
            LunarPillarPeonsKilled = tag.GetInt("LunarPillarPeonsKilled");
            pillarAequusInvasion = tag.GetBool("pillarAequusInvasion");
            SuperHardMode = tag.GetBool("SuperHardMode");
            DownedMage1 = tag.GetBool("DownedMage1");
            DownedEoC2 = tag.GetBool("EoC2");
            DownedGeodeWorm = tag.GetBool("DownedGeodeWorm");
        }
        public override void PreUpdate()
        {
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
            int count = 0;
            while (count < 1)
            {
                for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-04); k++)
                {
                    int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                    int y = WorldGen.genRand.Next((int)WorldGen.worldSurface, Main.maxTilesY);
                    Tile tile = Framing.GetTileSafely(x, y);
                    if (tile.active() && tile.type == TileID.Mud || tile.type == TileID.JungleGrass)
                    {
                        WorldGen.TileRunner(x, y, WorldGen.genRand.Next(4, 6), WorldGen.genRand.Next(3, 6), mod.TileType("LunarWoodTile"));
                    }
                }
                count++;
            }
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