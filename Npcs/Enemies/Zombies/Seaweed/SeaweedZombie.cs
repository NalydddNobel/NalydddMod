﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Npcs.Enemies.Zombies.Seaweed
{
    class SeaweedZombie : ModNPC
    {
        public override string Texture => "nalydmod/Npcs/Enemies/Zombies/Seaweed/SeaweedZombieTexture";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zombie");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
        }
        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 40;
            npc.damage = 16;
            npc.defense = 2;
            npc.lifeMax = 45;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 60f;
            npc.knockBackResist = 0.45f;
            npc.aiStyle = 3;
            npc.dripping = true;
            npc.onFire2 = false;
            aiType = NPCID.Zombie;
            animationType = NPCID.Zombie;
            banner = Item.NPCtoBanner(NPCID.Zombie);
            bannerItem = Item.BannerToItem(banner);
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (Main.raining == true)
            {
                return SpawnCondition.OverworldNightMonster.Chance * 0.25f;
            }
            else return SpawnCondition.OverworldNightMonster.Chance * 0.003f;
        }
        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore8"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore9"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore9"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore10"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore10"), 1f);
            }
            for (int i = 0; i < 10; i++)
            {
                int dustType = 5;
                int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
                Dust dust = Main.dust[dustIndex];
                dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
                dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
            }
        }
    }
}
