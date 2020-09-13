using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.NPCs
{
    public class AccessoryBuffs : GlobalNPC
    {
        public override void AI(NPC npc)
        {
            if (MyPlayer.hit)
            {
                if (npc.type == NPCID.MeteorHead)
                {
                    npc.damage = MyPlayer.dmg;
                }
            }
        }
    }
}