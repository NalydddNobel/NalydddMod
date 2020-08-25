using Terraria;
using Terraria.ModLoader;
namespace nalydmod
{
    public class nalydmod : Mod
    {
        public static int CustomCurrencyID;
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Main.dayTime && Main.time >= 50000)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/Sunset");
                priority = MusicPriority.BiomeLow;
            }
            if (!Main.dayTime && Main.bloodMoon)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/BloodMoon");
                priority = MusicPriority.BiomeMedium;
            }
            if (NPC.AnyNPCs(Terraria.ID.NPCID.KingSlime))
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/KingSlime");
                priority = MusicPriority.BossLow;
            }
            if (NPC.AnyNPCs(Terraria.ID.NPCID.EyeofCthulhu))
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/EyeofCuthulu");
                priority = MusicPriority.BossLow;
            }
        }
        public override void Load()
        {
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SnowBiomeTown"), ItemType("MusicBoxsnowbiometown"), TileType("MusicBoxsnowbiometownTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Sunset"), ItemType("MusicBoxsunset"), TileType("MusicBoxsunsetTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DungeonGarden"), ItemType("MusicBoxdungeon"), TileType("MusicBoxdungeonTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/CaveShrine"), ItemType("MusicBoxcaveshrine"), TileType("MusicBoxcaveshrineTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/CaveShrineAlt"), ItemType("MusicBoxcaveshrinealt"), TileType("MusicBoxcaveshrinealtTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossType1"), ItemType("MusicBoxboss1"), TileType("MusicBoxboss1Tile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/KingSlime"), ItemType("MusicBoxkingslime"), TileType("MusicBoxkingslimeTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/EyeofCuthulu"), ItemType("MusicBoxEyeofCuthulu"), TileType("MusicBoxEyeofCuthuluTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LunarEvil"), ItemType("MusicBoxlunar"), TileType("MusicBoxlunarTile"));
        }
    }
}