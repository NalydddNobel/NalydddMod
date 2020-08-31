using Terraria.ID;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
namespace nalydmod.NPCs.ItemDrops
{
    public class WOF : GlobalNPC
    {
        public override void OnHitByProjectile(NPC npc, Projectile projectile, int damage, float knockback, bool crit)
        {
            if (npc.type == NPCID.WallofFlesh || npc.type == NPCID.WallofFleshEye)
            {
                if (Main.rand.Next(2) == 0)
                {
                    MyWorld.wofWeakness += 1;
                }
            }
        }
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.WallofFlesh)
            {
                MyWorld.wofWeakness = 0;
            }
        }
        public override void AI(NPC npc)
        {
            if (npc.type == NPCID.TheHungry)
            {
                npc.life = npc.lifeMax - MyWorld.wofWeakness * 3;
            }
            if (npc.life < 1)
            {
                npc.life = 1;
            }
        }
    }
}