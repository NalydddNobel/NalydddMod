using nalydmod.NPCs;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod
{
    public class nalydmod : Mod
    {
        public static int CustomCurrencyID;
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            Player player = Main.player[Main.LocalPlayer.whoAmI];
            if (NPC.AnyNPCs(NPCID.EyeofCthulhu) && BossBuffs.buffedEoC)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/EyeofCuthulu");
                priority = MusicPriority.BossHigh;
            }
            else if (NPC.AnyNPCs(NPCID.KingSlime))
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/KingSlime");
                priority = MusicPriority.BossLow;
            }
            else if (MyPlayer.LunarBiome)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/LunarEvil");
                priority = MusicPriority.BiomeHigh;
            }
            else if (!Main.dayTime && Main.bloodMoon)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/BloodMoon");
                priority = MusicPriority.BiomeMedium;
            }
            else if (Main.dayTime && Main.time >= 50000 && player.ZoneOverworldHeight && !MyPlayer.LunarBiome)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/Sunset");
                priority = MusicPriority.BiomeLow;
            }
        }
        public override void Load()
        {
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SnowBiomeTown"), ItemType("MusicBoxsnowbiometown"), TileType("MusicBoxsnowbiometownTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Sunset"), ItemType("BBMusicBoxsunset"), TileType("MusicBoxsunsetTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DungeonGarden"), ItemType("MusicBoxdungeon"), TileType("MusicBoxdungeonTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/CaveShrine"), ItemType("MusicBoxcaveshrine"), TileType("MusicBoxcaveshrineTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/CaveShrineAlt"), ItemType("MusicBoxcaveshrinealt"), TileType("MusicBoxcaveshrinealtTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossType1"), ItemType("ABMusicBoxboss1"), TileType("MusicBoxboss1Tile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/KingSlime"), ItemType("AAMusicBoxkingslime"), TileType("MusicBoxkingslimeTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/EyeofCuthulu"), ItemType("ACMusicBoxEyeofCuthulu"), TileType("MusicBoxEyeofCuthuluTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LunarEvil"), ItemType("MusicBoxlunar"), TileType("MusicBoxlunarTile"));
            ModTranslation text = CreateTranslation("NPCTalk");
        }
        public override void PostSetupContent()
        {
            Mod bossChecklist = ModLoader.GetMod("BossChecklist");
            if (bossChecklist != null)
            {
                bossChecklist.Call(
                    "AddBoss",
                    1.5f,
                    ModContent.NPCType<Npcs.GeodeWormBossImage>(),
                    this,
                    "Geode Worm",
                    (Func<bool>)(() => MyWorld.DownedGeodeWorm),
                    ModContent.ItemType<Items.BossSummons.AAGeodeWorm>(),
                    new List<int> { ModContent.ItemType<Items.Placeables.Special.Trophys.AAGeodeWormTrophy>(), ModContent.ItemType<Items.Armor.Vanity.GeodeWormMask>(), ModContent.ItemType<Items.Placeables.Special.MusicBox.ABMusicBoxboss1>() },
                    new List<int> { ModContent.ItemType<Items.Accessories.AExpert.ABoss.BBBagofGems>(), ModContent.ItemType<Items.Materials.GemFragments.AmethystFragment>(), ModContent.ItemType<Items.Materials.GemFragments.TopazFragment>(), ModContent.ItemType<Items.Materials.GemFragments.SapphireFragment>(), ModContent.ItemType<Items.Materials.GemFragments.EmeraldFragment>(), ModContent.ItemType<Items.Materials.GemFragments.RubyFragment>(), ModContent.ItemType<Items.Materials.GemFragments.DiamondFragment>(), ModContent.ItemType<Items.Materials.GemFragments.LifeFragment>(), ItemID.Amethyst, ItemID.Topaz, ItemID.Sapphire, ItemID.Emerald, ItemID.Ruby, ItemID.Diamond },
                    $"Find a [i:{ModContent.ItemType<Items.BossSummons.AAGeodeWorm>()}] by crafting it or by finding it in Gold Chests. Then use it anywhere.",
                    "Geode Worm has dug back underground."

                );
                bossChecklist.Call(
                    "AddBoss",
                    3.5f,
                    ModContent.NPCType<Npcs.Enemies.Bosses.WaterMage.WaterMage>(),
                    this,
                    "Ancient Mage",
                    (Func<bool>)(() => MyWorld.DownedMage1),
                    ItemID.Meteorite,
                    new List<int> { ModContent.ItemType<Items.Accessories.AExpert.ABoss.FFMagicChannel>() },
                    new List<int> { ModContent.ItemType<Items.Expert.TreasureBags.Mage1TreasureBag>() },
                   "Found at meteor sites."
                );
                if (Main.expertMode)
                {
                    bossChecklist.Call(
                   "AddBoss",
                   14.1f,
                   ModContent.NPCType<Npcs.Enemies.Bosses.LunarPillar.LunarPillar>(),
                   this,
                   "Aequus Pillar",
                   (Func<bool>)(() => MyWorld.DownedLunarPillar),
                   ModContent.ItemType<Items.BossSummons.GGAbsque>(),
                   new List<int> { ModContent.ItemType<Items.Expert.Bars.SolarBar>(), ModContent.ItemType<Items.AADev.BBNalydwings>() },
                   new List<int> { ModContent.ItemType<Items.Expert.TreasureBags.LunarPillarTreasureBag>() },
                   "(Expert Mode Only) Spawns after Moonlord is defeated."
               );
                    bossChecklist.Call(
                    "AddBoss",
                    14.5f,
                    ModContent.NPCType<Npcs.Enemies.Bosses.LunarPillar.LunarPillar>(),
                    this,
                    "Eye of Cthulhu (Buffed)",
                    (Func<bool>)(() => MyWorld.DownedEoC2),
                    ModContent.ItemType<Items.BossSummons.CCInfEye>(),
                    new List<int> { ModContent.ItemType<Items.Expert.Bars.SolarBar>(), ModContent.ItemType<Items.AADev.BBNalydwings>() },
                    new List<int> { ModContent.ItemType<Items.Expert.TreasureBags.buffedEoCTreasureBag>() },
                   $"(Expert Mode Only) Use a [i:{ModContent.ItemType<Items.BossSummons.CCInfEye>()}] at night."
                );
                }
            }
        }
    }
}