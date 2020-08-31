using System;
using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Npcs.Enemies
{
    class TestNPC1 : ModNPC
    {
        private Player player;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Test NPC I");
        }
        public override void SetDefaults()
        {
            npc.damage = 10;
            npc.defense = 5;
            npc.lifeMax = 100;
            npc.value = 100;
            npc.knockBackResist = 0.25f;
            npc.aiStyle = -1;
            npc.noGravity = true;
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
                    int dustType = 5;
                    int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
                    Dust dust = Main.dust[dustIndex];
                    dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                    dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
                    dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
                }
            }
        }
        public override bool PreAI()
        {
            return true;
        }
        private void Target()
        {
            player = Main.player[npc.target];
        }
        public override void AI()
        {
            Target();
            npc.rotation = (float)Math.Atan2(npc.velocity.Y, npc.velocity.X) + 3.14f;
            if (Main.dayTime == true)
            {
                if (npc.behindTiles == true)
                {
                    npc.life = 0;
                }
                if (npc.velocity.X <= 0)
                {
                    npc.velocity.X = 0;
                }
                if (npc.velocity.Y <= 0)
                {
                    npc.velocity.Y = 0;
                }
            }
        }
    }
}