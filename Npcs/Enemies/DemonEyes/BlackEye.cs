﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Npcs.Enemies.DemonEyes
{
    class BlackEye : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demon Eye");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DemonEye];
        }
		public override void SetDefaults()
		{
			npc.width = 38;
			npc.height = 23;
			npc.damage = 14;
			npc.defense = 4;
			npc.lifeMax = 60;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 60f;
			npc.knockBackResist = 0.23f;
			npc.aiStyle = 2;
			npc.dripping = true;
			aiType = NPCID.DemonEye;
			animationType = NPCID.DemonEye;
			banner = Item.NPCtoBanner(NPCID.DemonEye);
			bannerItem = Item.BannerToItem(banner);
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{	
				return SpawnCondition.OverworldNight.Chance * 0.01f;
		}
		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore3"), 1f);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore4"), 1f);
			}
            else
            {
				for (int i = 0; i < 10; i++)
				{
					int dustType = 219;
					int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
					Dust dust = Main.dust[dustIndex];
					dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
					dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
					dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
				}
			}
		}
	}
}