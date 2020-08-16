using nalydmod.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.NPCs.ItemDrops.Boss
{
    public class KingSlimeDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            int RandomNumber = (int)Main.rand.NextFloat(5, 12);
            if (npc.type == NPCID.KingSlime)    
            {
                if (Main.expertMode == false)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RoyalGel"), RandomNumber);
                }
            }                                                                                             
        }
    }
}




