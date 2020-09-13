using Microsoft.Xna.Framework;
using nalydmod.Dusts;
using Terraria;
using Terraria.ModLoader;
namespace nalydmod.NPCs.ItemDrops
{
    public class Global : GlobalNPC
    {
        public override bool InstancePerEntity => true;

        public bool deadlyFlames;
        public override void ResetEffects(NPC npc)
        {
            deadlyFlames = false;
        }
        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (deadlyFlames)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 16;
                if (damage < 2)
                {
                    damage = 2;
                }
            }
        }
        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (deadlyFlames)
            {
                if (Main.rand.Next(2) == 0)
                {
                    int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, ModContent.DustType<DeadlyFlameDust>(), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default, 1.22f);
                    Main.dust[dust].velocity *= 1.8f;
                    Main.dust[dust].velocity.Y -= 0.5f;
                }
                if (Main.rand.Next(8) == 0)
                {
                    int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, ModContent.DustType<DeadlyFlameDust>(), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default, 1.22f);
                    Main.dust[dust].velocity *= 1.8f;
                    Main.dust[dust].velocity.Y -= 0.5f;
                }
                if (Main.rand.Next(2) == 0)
                {
                    int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, ModContent.DustType<DeadlyFlameDust2>(), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default, 0.88f);
                    Main.dust[dust].velocity *= 1.8f;
                    Main.dust[dust].velocity.Y -= 0.5f;
                }
                if (Main.rand.Next(4) == 0)
                {
                    int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, ModContent.DustType<DeadlyFlameDust2>(), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default, 1f);
                    Main.dust[dust].velocity *= 1.8f;
                    Main.dust[dust].velocity.Y -= 0.5f;
                }
                Lighting.AddLight((int)(npc.position.X / 16f), (int)(npc.position.Y / 16f), 0, 0.66f, 0.90f);
            }
        }
    }
}