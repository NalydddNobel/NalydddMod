using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Npcs.Enemies.Corruption
{
    class CorruptedMush : ModNPC
    {
        int frame;
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 3;
        }
        public override void SetDefaults()
        {
            npc.width = 24;
            npc.height = 24;
            npc.damage = 0;
            npc.rarity = 1;
            npc.defense = 6;
            npc.lifeMax = 144;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 60f;
            npc.knockBackResist = 0f;
            npc.dripping = true;
            npc.onFire2 = false;
            aiType = -1;
        }
        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore16"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore19"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore18"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore18"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore17"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NpcGore17"), 1f);
                int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, 18);
                Dust dust = Main.dust[dustIndex];
                dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
                dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, 18);
                    Dust dust = Main.dust[dustIndex];
                    dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                    dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
                    dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
                }
            }
        }
        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CursedSparks"), Main.rand.Next(0, 5));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood2"));
            if (Main.rand.Next(12) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofNight);
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Corruption.Chance * 0.3f;
        }
        public override void AI()
        {
            if (Main.rand.Next(5) == 0)
            {
                npc.frameCounter++;
            }
            npc.frameCounter++;
            if (npc.frameCounter >= 12)
            {
                npc.frameCounter = 0;
                frame++;
            }
            if (frame > 2)
            {
                frame = 0;
            }
            npc.frame.Y = frame * 30;
            if (Main.rand.Next(44) == 0)
            {
                int dust = Dust.NewDust(npc.position * Main.rand.Next(1, 2), npc.width, npc.height, mod.DustType("CursedFlameDust"));
                Main.dust[dust].scale = Main.rand.Next(6, 12) * .1f;
            }
        }
    }
}