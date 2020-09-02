using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Npcs.Enemies
{
    [AutoloadBossHead]
    class TestNPC1 : ModNPC
    {
        public bool toggle;
        public float speedY;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Test NPC I");
        }
        public override void SetDefaults()
        {
            npc.damage = 0;
            npc.defense = 5;
            npc.lifeMax = 100;
            npc.value = 100;
            npc.noTileCollide = true;
            npc.noGravity = true;
            npc.knockBackResist = 0.25f;
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
                    int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, DustID.Blood);
                    Dust dust = Main.dust[dustIndex];
                    dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                    dust.velocity.Y = speedY + Main.rand.Next(-50, 51) * 0.01f;
                    dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
                }
            }
        }
        public override void AI()
        {
            Player player = Main.player[npc.target];
            speedY += npc.ai[0] * 0.04f;
            if (toggle)
            {
                npc.ai[0]++;
            }
            if (!toggle)
            {
                npc.ai[0]--;
            }
            if (toggle && npc.position.Y >= player.Center.Y + 16)
            {
                toggle = false;
            }
            if (!toggle && npc.position.Y <= player.Center.Y - 16)
            {
                toggle = true;
            }
            npc.position.Y = player.Center.Y + speedY;
            npc.position.X = player.Center.X;
        }
    }
}