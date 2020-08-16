using Microsoft.Xna.Framework;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using nalydmod.Npcs;
using static Terraria.ModLoader.ModContent;
using System.Threading;
using Terraria.ModLoader.Config;
using System;

namespace nalydmod.Npcs.Enemies.Slimes
{
    class PurpleSpikedSlime: ModNPC
    {
		public override string Texture => "nalydmod/Npcs/Enemies/Slimes/BasicSpikedSlime";
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purple Spiked Slime");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.SlimeSpiked];
        }
		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.SlimeSpiked);
			aiType = NPCID.SlimeSpiked;
			animationType = NPCID.SlimeSpiked;
			npc.lifeMax = 45;
			npc.damage = 12;
			npc.defense = 7;
		    npc.knockBackResist = 1f;
			npc.color = Color.Purple;
			banner = Item.NPCtoBanner(NPCID.PurpleSlime);
			bannerItem = Item.BannerToItem(banner);
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
			bool SlimeOutrage = NPC.downedSlimeKing == true;
			if (SlimeOutrage == true)
			{
				return SpawnCondition.OverworldDaySlime.Chance * 0.01f;
			}
			else return 0;
		}
	}
}
