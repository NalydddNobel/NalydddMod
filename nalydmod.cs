using IL.Terraria.GameContent.UI;
using IL.Terraria.ID;
using nalydmod.Items;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;


namespace nalydmod
{
    public class nalydmod : Mod
    {
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (NPC.AnyNPCs(Terraria.ID.NPCID.KingSlime))
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/KingSlime"); ;
                priority = MusicPriority.BossMedium;
            }
            
        }


        public static int CustomCurrencyID;

        public override void Load()
        {
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Sunset"), ItemType("MusicBoxsunset"), TileType("MusicBoxsunsetTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DungeonGarden"), ItemType("MusicBoxdungeon"), TileType("MusicBoxdungeonTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/CaveShrine"), ItemType("MusicBoxcaveshrine"), TileType("MusicBoxcaveshrineTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/CaveShrineAlt"), ItemType("MusicBoxcaveshrinealt"), TileType("MusicBoxcaveshrinealtTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossType1"), ItemType("MusicBoxboss1"), TileType("MusicBoxboss1Tile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/KingSlime"), ItemType("MusicBoxkingslime"), TileType("MusicBoxkingslimeTile"));
            AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LunarEvil"), ItemType("MusicBoxlunar"), TileType("MusicBoxlunarTile"));
        }
    }
}











